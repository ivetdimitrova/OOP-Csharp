using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelConsumption, double fuelQuantity, double tankCapacity) : base(fuelConsumption, fuelQuantity, tankCapacity)
        {
        }

        protected override double ConsumptionIncrease => 1.4;
        public override void Refuel(double amount)
        {
            if (amount > base.TankCapacity) throw new ArgumentException($"Cannot fit {amount} fuel in the tank");
            base.FuelQuantity += amount;
        }

        public bool CanDriveWhenIsFull(double distance)
        {
            double consumption = distance * (FuelConsumption + ConsumptionIncrease);

            if (FuelQuantity < consumption)
                return false;

            FuelQuantity -= consumption;
            return true;
        }
    }
}
