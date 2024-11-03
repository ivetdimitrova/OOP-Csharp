using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelConsumption, double fuelQuantity, double tankCapacity) : base(fuelConsumption, fuelQuantity, tankCapacity)
        {
        }

        protected override double ConsumptionIncrease => 1.6;
        public override void Refuel(double amount)
        {
            if (amount > base.TankCapacity) throw new ArgumentException($"Cannot fit {amount} fuel in the tank");
            base.FuelQuantity += amount * 0.95;
        }
    }
}
