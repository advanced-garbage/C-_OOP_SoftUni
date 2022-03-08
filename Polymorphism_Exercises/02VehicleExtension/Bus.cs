using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double quantity, double consumption, double tank) : base(quantity, consumption, tank) { }

        public override string ToString() => $"Bus: {this.FuelQuantity:f2}";
    }
}
