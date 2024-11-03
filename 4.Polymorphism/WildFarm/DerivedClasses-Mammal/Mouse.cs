using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.DerivedClasses_Animal;
using WildFarm.Models;

namespace WildFarm.DerivedClasses_Mammal
{
    public class Mouse : Mammal
    {
        public override string Sound => "Squeak";
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override double IncreasedWeight => 0.1;
        public override void Еаt(Food food)
        {
            if (CanEat(food))
            {
                base.Еаt(food);
            }
            else
            {
                throw new ArgumentException($"Mouse does not eat {food.GetType().Name}!");
            }
        }

        private bool CanEat(Food food) => food.GetType().Name == "Vegetable" || food.GetType().Name == "Fruit";
    }
}
