using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(base.ExplainSelf());
            result.Append("DJAAF");

            return result.ToString();
        }
    }
}
