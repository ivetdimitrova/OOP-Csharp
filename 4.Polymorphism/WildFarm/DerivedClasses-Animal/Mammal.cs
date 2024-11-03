using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.BaseClasses;

namespace WildFarm.DerivedClasses_Animal
{
    public class Mammal : Animal
    {
        public virtual string Sound { get; }
        public Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            LivingRegion = livingRegion;
        }

        public string LivingRegion { get; }
        public override string ProduceSound()
        {
            return Sound;
        }
        public override string ToString() => $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    
    }
}
