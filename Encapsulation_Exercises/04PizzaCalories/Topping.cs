using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        List<string> check_toppings = new List<string>() { "meat", "veggies", "cheese", "sauce" };
        private string toppingType;
        private int weight;
        public Topping(string topping, int weight)
        {
            this.ToppingType = topping;
            this.Weight = weight;
        }
        public string ToppingType
        {
            get { return this.toppingType; }
            private set {
                try {
                    if (!check_toppings.Contains(value?.ToLower()))
                        throw new Exception();
                    this.toppingType = value;
                }
                catch (Exception) {
                    Console.WriteLine($"Cannot place {value} on top of your pizza.");
                    Environment.Exit(0);
                }
            }
        }
        public int Weight
        {
            get { return this.weight; }
            set {
                try {
                    if (value < 1 || value > 50)
                        throw new Exception();
                    this.weight = value;
                }
                catch (Exception) {
                    Console.WriteLine($"{this.ToppingType} weight should be in the range [1..50].");
                    Environment.Exit(0);
                }
            }
        }
        public double CountCalories => GetCalories();
        private double GetCalories()
        {
            double modifier = 0;
            switch (this.ToppingType?.ToLower())
            {
                case "meat": modifier = 1.2;
                    break;
                case "veggies": modifier = 0.8;
                    break;
                case "cheese": modifier = 1.1;
                    break;
                case "sauce": modifier = 0.9;
                    break;
            }
            return (2 * this.Weight) * modifier;
        }

        public override string ToString()
        {
            return $"{this.GetCalories():f2}";
        }
    }
}
