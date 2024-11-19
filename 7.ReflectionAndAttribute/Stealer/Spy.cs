using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {

        public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
        {
            Type classType = Type.GetType(investigatedClass);

            FieldInfo[] classFields = classType.GetFields((BindingFlags)60);
          

            Object instance = Activator.CreateInstance(classType);

            StringBuilder result = new StringBuilder();
            result.AppendLine($"Class under investigation: {classType.Name}");

            foreach (FieldInfo field in classFields.Where(f => requestedFields.Contains(f.Name)))
            {
                result.AppendLine($"{field.Name} = {field.GetValue(instance)}");
            }

            return result.ToString();
        }

        public string AnalyzeAccessModifiers(string className)
        {
            Type classType = Type.GetType(className);

            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance|BindingFlags.Static| BindingFlags.Public);
            MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] classPrivateMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder result = new StringBuilder();
            foreach ( FieldInfo field in classFields)
            {
                result.AppendLine($"{field.Name} must be private!");
            }

            foreach (MethodInfo method in classPublicMethods.Where(m => m.Name.StartsWith("get")))
            {
                result.AppendLine($"{method.Name} have to be public!");
            }

            foreach (MethodInfo method in classPrivateMethods.Where(m => m.Name.StartsWith("set")))
            {
                result.AppendLine($"{method.Name} have to be private!");
            }

            return result.ToString();
        }


        public string RevealPrivateMethods(string className)
        {
            Type classType = Type.GetType(className);

            MethodInfo[] classPrivateMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder result = new StringBuilder();
            result.AppendLine($"All Private Methods of Class: {className}");
            result.AppendLine($"Base Class: {classType.BaseType.Name}");

            foreach (MethodInfo method in classPrivateMethods)
            {
                result.AppendLine($"{method.Name}");
            }

            return result.ToString();
        }

        public string CollectGettersAndSetters(string className)
        {
            Type classType = Type.GetType(className);

            MethodInfo[] classMethods = classType.GetMethods((BindingFlags)60);

            StringBuilder result = new StringBuilder();
            foreach (MethodInfo method in classMethods.Where(m => m.Name.StartsWith("get")))
            {
                result.AppendLine($"{method.Name} will return {method.ReturnType}");
            }

            foreach (MethodInfo method in classMethods.Where(m => m.Name.StartsWith("set")))
            {
                result.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return result.ToString().Trim();
        }
    }
}
