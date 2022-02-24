using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public override double FuelConsumption => this.DefaultFuelConsumption;

        public SportCar(int horsepower, double fuel) : base(horsepower, fuel)
        {
            this.DefaultFuelConsumption = 10;
        }

        public override void Drive(double kilometers)
        {
            Fuel -= (kilometers * FuelConsumption);
        }
    }
}
