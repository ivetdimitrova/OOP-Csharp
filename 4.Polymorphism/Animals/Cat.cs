using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public  class Cat : Animal
    {
        public Cat(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(base.ExplainSelf());
            result.Append("MEEOW");

            return result.ToString();
        }
    }
}
