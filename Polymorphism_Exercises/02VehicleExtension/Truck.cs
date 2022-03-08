using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double quantity, double consumption, double tank) : base(quantity, consumption, tank)
        {
            this.FuelConsumption += 1.6;
        }

        public override void Refuel(double fuel)
        {
            if (fuel <= 0)
                Console.WriteLine("Fuel must be a positive number");
            else if (this.TankCapacity - this.FuelQuantity < fuel || this.TankCapacity == 0)
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            else {
                fuel -= fuel * 0.05;
                this.FuelQuantity += fuel; }
        }

        public override string ToString() => $"Truck: {this.FuelQuantity:F2}";
    }
}
