using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(100, 10);
            Console.WriteLine(vehicle.Drive(2));

            Motorcycle motorcycle = new Motorcycle(200, 15);
            Console.WriteLine(motorcycle.Drive(2));

            RaceMotorcycle raceMotorcycle = new RaceMotorcycle(250, 10);
            Console.WriteLine(raceMotorcycle.Drive(2));

            CrossMotorcycle crossMotorcycle = new CrossMotorcycle(120, 17.5);
            Console.WriteLine(crossMotorcycle.Drive(2));

            Car car = new Car(100, 20);
            Console.WriteLine(car.Drive(2));

            FamilyCar familyCar = new FamilyCar(90, 25);
            Console.WriteLine(familyCar.Drive(2));

            SportCar sportCar = new SportCar(300, 20);
            Console.WriteLine(sportCar.Drive(2));

        }
    }
}
