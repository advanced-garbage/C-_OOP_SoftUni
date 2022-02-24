using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public double DefaultFuelConsumption { get; set; }
        virtual public double FuelConsumption { get { return this.DefaultFuelConsumption; } }

        public Vehicle (int horsepower, double fuel)
        {
            HorsePower = horsepower;
            Fuel = fuel;
            DefaultFuelConsumption = 1.25;
        }

        public virtual void Drive(double kilometers)
        {
            Fuel -= (kilometers * FuelConsumption);
        }
    }
}
