using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        public Vehicle(int horsepower, double fuel)
        {
            this.Fuel = fuel;
            this.HorsePower  = horsepower;
        } 
     
        public double Fuel { get; set; }
        public int HorsePower { get; }

        public virtual double FuelConsumption => DefaultFuelConsumption;

        public double Drive(double kilometers)
        {
            return this.Fuel -= this.FuelConsumption * kilometers;
        }
    }
}
