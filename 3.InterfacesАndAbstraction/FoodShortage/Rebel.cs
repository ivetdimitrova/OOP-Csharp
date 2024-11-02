using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public class Rebel:Person, IBuyer
    {
        public Rebel(string name, int age, string group) : base(name, age)
        {
            this.Group = group;
        }

        public int Food { get; private set; }

        public string Group { get; }
        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
