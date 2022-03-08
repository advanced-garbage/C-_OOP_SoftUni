using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double quantity, double consumption) : base(quantity, consumption)
        {
            this.FuelConsumption += 1.6;
        }

        public override void Refuel(double fuel)
        {
            fuel -= 0.05 * fuel;
            base.Refuel(fuel);
        }

        public override string ToString()
        {
            return $"Truck: {this.FuelQuantity:F2}";
        }
    }
}
