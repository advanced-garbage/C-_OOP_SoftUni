
using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public override double FuelConsumption => this.DefaultFuelConsumption;
        public Car(int horsepower, double fuel) : base(horsepower, fuel)
        {
            this.DefaultFuelConsumption = 3;
        }

        public override void Drive(double kilometers)
        {
            Fuel -= (kilometers * FuelConsumption);
        }
    }
}
