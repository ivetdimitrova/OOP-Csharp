﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class SportCar :Car
    {
        private const double DefaultFuelConsumption = 10;

        public SportCar(int horsepower, double fuel) : base(horsepower, fuel)
        {
        }

        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
