using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.DerivedClasses_Mammal;
using WildFarm.Models;

namespace WildFarm.DerivedClasses_Feline
{
    internal class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override string Sound => "ROAR!!!";

        public override double IncreasedWeight => 1.00;
        public override void Еаt(Food food)
        {
            if (CanEat(food))
            {
                base.Еаt(food);
            }
            else
            {
                throw new ArgumentException($"Tiger does not eat {food.GetType().Name}!");
            }
        }

        private bool CanEat(Food food) => food.GetType().Name == "Meat";
    }
}
