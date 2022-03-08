using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double quantity, double consumption, double tank) : base(quantity, consumption, tank)
        {
            this.FuelConsumption += 0.9;
        }

        public override string ToString() => $"Car: {this.FuelQuantity:F2}";
    }
}
