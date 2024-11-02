using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Car: Vehicle
    {
        private const double DefaultFuelConsumption = 3;

        public Car(int horsepower, double fuel) : base(horsepower, fuel)
        {
        }

         public override double FuelConsumption => DefaultFuelConsumption;
    }
}
