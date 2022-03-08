using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Vehicle(double quantity, double consumption)
        {
            this.FuelQuantity = quantity;
            this.FuelConsumption = consumption;
        }
        public void Drive(double km) {
            bool isThereEnoughFuel = this.FuelQuantity >= this.FuelConsumption * km;
            if (isThereEnoughFuel) {
                Console.WriteLine($"{this.GetType().Name} travelled {km} km");
                this.FuelQuantity -= this.FuelConsumption * km;
            } else {
                Console.WriteLine($"{this.GetType().Name} needs refueling"); } }
        public virtual void Refuel(double fuel) {
            this.FuelQuantity += fuel;  }
    }
}
