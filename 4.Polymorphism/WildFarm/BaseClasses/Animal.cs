using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models;

namespace WildFarm.BaseClasses
{
    public abstract class Animal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }

        public virtual double IncreasedWeight{ get; }

        public abstract string ProduceSound();

        public virtual void Еаt(Food food)
        {
            Weight += food.Quantity * IncreasedWeight;
            FoodEaten += food.Quantity;
        }

        public abstract string ToString();
    }
}
