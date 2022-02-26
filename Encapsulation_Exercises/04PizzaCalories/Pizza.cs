using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
        }
        public string Name
        {
            get { return this.name; }
            private set {
                try {
                    if (string.IsNullOrEmpty(value) || value.Length > 15)
                        throw new Exception();
                    this.name = value;
                }
                catch (Exception) {
                    Console.WriteLine("Pizza name should be between 1 and 15 symbols.");
                    Environment.Exit(0);
                }
            }
        }
        public Dough Dough
        {
            get { return this.dough; }
            set { this.dough = value; }
        }
        public List<Topping> Toppings => this.toppings;

        public void AddTopping(Topping topping)
        {
            try {
                if (this.toppings.Count + 1 > 10)
                    throw new Exception();
                this.toppings.Add(topping);
            }
            catch (Exception) {
                Console.WriteLine("Number of toppings should be in range [0..10].");
                Environment.Exit(0);
            }
        }

        private double TotalCalories()
        {
            double total = 0;
            total += this.Dough.CountCalories;
            foreach (var top in toppings)
                total += top.CountCalories;
            return total;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.TotalCalories():f2} Calories.";
        }
    }
}
