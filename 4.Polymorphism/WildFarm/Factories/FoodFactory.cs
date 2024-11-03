using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.DerivedClasses_Bird;
using WildFarm.DerivedClasses_Feline;
using WildFarm.DerivedClasses_Food;
using WildFarm.DerivedClasses_Mammal;
using WildFarm.Models;

namespace WildFarm.Factories
{
    public class FoodFactory
    {
        public static Food CreateFood(string[] data)
        {
            string foodType = data[0];

            switch (foodType)
            {
                case "Vegetable":
                    return new Vegetable(int.Parse(data[1]));
                case "Fruit":
                    return new Fruit(int.Parse(data[1]));
                case "Meat":
                    return new Meat(int.Parse(data[1]));
                case "Seeds":
                case "Seed":
                    return new Seeds(int.Parse(data[1])); 
                default:
                    return null;

            }
        }
    }
}
