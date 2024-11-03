using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.DerivedClasses_Animal;
using WildFarm.Models;

namespace WildFarm.DerivedClasses_Bird
{
    public class Owl:Bird
    {
        public override string Sound => "Hoot Hoot";
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override double IncreasedWeight => 0.25;
        public override void Еаt(Food food)
        {
            if (CanEat(food))
            {
                base.Еаt(food);
            }
            else
            {
                throw new ArgumentException($"Owl does not eat {food.GetType().Name}!");
            }
        }

        private bool CanEat(Food food) => food.GetType().Name == "Meat";
    }
}
