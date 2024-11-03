using WildFarm.BaseClasses;
using WildFarm.Factories;
using WildFarm.Models;

namespace WildFarm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] animalData = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                Animal animal = AnimalFactory.CreateAnimal(animalData);

                animals.Add(animal);

                string[] foodData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                Food food = FoodFactory.CreateFood(foodData);

                Console.WriteLine(animal.ProduceSound());
                try
                {
                    animal.Еаt(food);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
              
            }


            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
