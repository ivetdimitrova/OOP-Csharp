using System;
using System.Linq;
using System.Reflection;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class CommandInterpreter :ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] data = args
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string commandName = data[0] + "Command";
            string[] commandArgs = data.Skip(1).ToArray();

            Type commandType = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .Where(x => x.Name == commandName)
                .FirstOrDefault();

            ICommand command = (ICommand)Activator.CreateInstance(commandType);

            return command.Execute(commandArgs);
        }
    }
}
