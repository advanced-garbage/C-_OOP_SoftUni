using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public override double FuelConsumption => this.DefaultFuelConsumption;
        public RaceMotorcycle(int horsepower, double fuel): base(horsepower, fuel)
        {
            this.DefaultFuelConsumption = 8;
        }
        public override void Drive(double kilometers)
        {
            Fuel -= (kilometers * FuelConsumption);
        }
    }
}
