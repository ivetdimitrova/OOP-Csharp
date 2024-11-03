using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.BaseClasses;
using WildFarm.DerivedClasses_Bird;
using WildFarm.DerivedClasses_Feline;
using WildFarm.DerivedClasses_Mammal;

namespace WildFarm.Factories
{
    public class AnimalFactory
    {
        public static Animal CreateAnimal(string[] data)
        {
            string animalType = data[0];

            switch (animalType)
            {
                case "Owl":
                    return new Owl(data[1], double.Parse(data[2]), double.Parse(data[3]));
                case "Hen":
                    return new Hen(data[1], double.Parse(data[2]), double.Parse(data[3]));
                case "Mouse":
                    return new Mouse(data[1], double.Parse(data[2]), data[3]);
                case "Dog":
                    return new Dog(data[1], double.Parse(data[2]), data[3]);
                case "Cat":
                    return new Cat(data[1], double.Parse(data[2]), data[3], data[4]);
                case "Tiger":
                    return new Tiger(data[1], double.Parse(data[2]), data[3], data[4]);
                default:
                    return null;

            }
        }
    }
}
