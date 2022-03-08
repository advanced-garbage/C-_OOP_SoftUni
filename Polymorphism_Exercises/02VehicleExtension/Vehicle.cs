using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double _tankCapacity;
        public double TankCapacity
        {
            get { return this._tankCapacity; }
            set { if (this.FuelQuantity > value)
                    this.FuelQuantity = 0;
                  this._tankCapacity = value; }
        }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Vehicle(double quantity, double consumption, double tank)
        {
            this.FuelQuantity = quantity;
            this.FuelConsumption = consumption;
            this.TankCapacity = tank;
        }
        public virtual void Drive(double km) 
        {
            bool isThereEnoughFuel = this.FuelQuantity >= this.FuelConsumption * km;
            if (isThereEnoughFuel) {
                Console.WriteLine($"{this.GetType().Name} travelled {km} km");
                this.FuelQuantity -= this.FuelConsumption * km;
            } else {
                Console.WriteLine($"{this.GetType().Name} needs refueling"); } 
        }
        public virtual void Drive(double km, bool isEmpty)
        {
            double fuelModified = this.FuelConsumption;
            if (!isEmpty)
                fuelModified += 1.4;

            bool isThereEnoughFuel = this.FuelQuantity >= fuelModified * km;
            if (isThereEnoughFuel) {
                Console.WriteLine($"{this.GetType().Name} travelled {km} km");
                this.FuelQuantity -= fuelModified * km;
            } else {
                Console.WriteLine($"{this.GetType().Name} needs refueling"); }
        }
        public virtual void Refuel(double fuel) {
            if (fuel <= 0)
                Console.WriteLine("Fuel must be a positive number");
            else if (this.TankCapacity - this.FuelQuantity < fuel || this.TankCapacity == 0)
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            else
                this.FuelQuantity += fuel;
        }
    }
}
