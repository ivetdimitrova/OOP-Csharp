using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Interfaces;

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        public Vehicle(double fuelConsumption, double fuelQuantity,double tankCapacity)
        {
            if (fuelQuantity <= tankCapacity) this.FuelQuantity = fuelQuantity;

            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        private double fuelQuantity;
        public double FuelQuantity { get;set; }

        public double FuelConsumption { get; }
        public double TankCapacity { get; }

        protected virtual double ConsumptionIncrease { get; }


        public  bool CanDrive(double distance)
        {
            double consumption = distance * (FuelConsumption + ConsumptionIncrease);
            if (FuelQuantity < consumption)
                return false;

            FuelQuantity -= consumption;
            return true;
        }


        public abstract void Refuel(double amount);

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
