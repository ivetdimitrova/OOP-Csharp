using Vehicles.Interfaces;

namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Vehicle car = new Car(double.Parse(data[2]), double.Parse(data[1]), double.Parse(data[3]));

            data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Vehicle truck = new Truck(double.Parse(data[2]), double.Parse(data[1]), double.Parse(data[3]));

            data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Bus bus = new Bus(double.Parse(data[2]), double.Parse(data[1]), double.Parse(data[3]));

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string action = command[0];
                string vehicleType = command[1];
                double value = double.Parse(command[2]);

                try
                {


                    if (vehicleType == "Car")
                    {
                        ExecutesTheAction(car, action, value);
                    }
                    else if (vehicleType == "Truck")
                    {
                        ExecutesTheAction(truck, action, value);
                    }
                    else if (vehicleType == "Bus")
                    {
                        if (action == "DriveEmpty")
                        {
                            ExecutesTheAction(bus, value);
                        }
                        else
                        {
                            Vehicle bus1 = bus;
                            ExecutesTheAction(bus, action, value);
                        }

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ExecutesTheAction(Bus bus, double value)
        {
            if (bus.CanDriveWhenIsFull(value))
            {
                Console.WriteLine($"{bus.GetType().Name} travelled {value} km");
            }
            else
            {
                Console.WriteLine($"{bus.GetType().Name} needs refueling");

            }
        }

        private static void ExecutesTheAction(Vehicle vehicle, string action, double value)
        {
            switch (action)
            {
                case "Drive":
                    if (vehicle.CanDrive(value))
                    {
                        Console.WriteLine($"{vehicle.GetType().Name} travelled {value} km");
                    }
                    else
                    {
                        Console.WriteLine($"{vehicle.GetType().Name} needs refueling");
                    }

                    break;
                case "Refuel":
                    if (value <= 0) throw new ArgumentException("Fuel must be a positive number");
                    vehicle.Refuel(value);
                    break;
            }
        }
    }
}
