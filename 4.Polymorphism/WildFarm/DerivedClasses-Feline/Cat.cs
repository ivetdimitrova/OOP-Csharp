using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.DerivedClasses_Mammal;
using WildFarm.Models;

namespace WildFarm.DerivedClasses_Feline
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override string Sound => "Meow";

        public override double IncreasedWeight => 0.30;
        public override void Еаt(Food food)
        {
            if (CanEat(food))
            {
                base.Еаt(food);
            }
            else
            {
                throw new ArgumentException ($"Cat does not eat {food.GetType().Name}!");
            }
        }

        private bool CanEat(Food food) => food.GetType().Name == "Vegetable" || food.GetType().Name == "Meat";
    }
}
