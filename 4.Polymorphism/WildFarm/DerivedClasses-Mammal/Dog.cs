using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.DerivedClasses_Animal;
using WildFarm.Models;

namespace WildFarm.DerivedClasses_Mammal
{
    public class Dog : Mammal
    {
        public override string Sound => "Woof!";
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override double IncreasedWeight => 0.4;
        public override void Еаt(Food food)
        {
            if (CanEat(food))
            {
                base.Еаt(food);
            }
            else
            {
                throw new ArgumentException($"Dog does not eat {food.GetType().Name}!");
            }
        }

        private bool CanEat(Food food) => food.GetType().Name == "Meat";
    }
}
