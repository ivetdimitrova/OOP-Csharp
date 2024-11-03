using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.BaseClasses;

namespace WildFarm.DerivedClasses_Animal
{
    public  class Bird : Animal
    {
        public virtual string Sound { get; }
        public Bird(string name, double weight, double wingSize) : base(name, weight)
        {
            WingSize = wingSize;
        }

        public double WingSize { get; }

        public override string ProduceSound()
        {
            return Sound;
        }

        public override string ToString() => $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
    }
}
