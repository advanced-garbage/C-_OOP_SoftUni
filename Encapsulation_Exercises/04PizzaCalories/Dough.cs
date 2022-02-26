using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        // White - 1.5
        // Wholegrain - 1.0
        // Crispy - 0.9
        // Chewy - 1.1
        // Homemade - 1.0
        List<string> check_flour = new List<string>() { "white", "wholegrain" };
        List<string> check_baking = new List<string>() { "chewy", "crispy", "homemade" };
        private string flourType;
        private string bakingType;
        private int weight; // per grams
        public Dough(string flour, string bake, int weight)
        {
            this.FlourType = flour;
            this.BakingType = bake;
            this.Weight = weight;
        }
        public string FlourType
        {
            get { return this.flourType; }
            private set {
                try {
                    if (!check_flour.Contains(value?.ToLower()))
                        throw new Exception();
                    this.flourType = value;
                }
                catch (Exception) {
                    Console.WriteLine("Invalid type of dough.");
                    Environment.Exit(0);
                }
            }
        }
        public string BakingType
        {
            get { return this.bakingType; }
            private set {
                try {
                    if (!check_baking.Contains(value?.ToLower()))
                        throw new Exception();
                    this.bakingType = value;
                }
                catch (Exception) {
                    Console.WriteLine("Invalid type of dough.");
                    Environment.Exit(0);
                }
            }
        }
        public int Weight
        {
            get { return this.weight; }
            private set {
                try {
                    if (value < 1 || value > 200)
                        throw new Exception();
                    this.weight = value;
                }
                catch (Exception) {
                    Console.WriteLine("Dough weight should be in the range [1..200].");
                    Environment.Exit(0);
                }
            }
        }
        public double CountCalories => GetCalories();
        private double GetCalories()
        {
            double modifier1 = 0;
            double modifier2 = 0;
            switch (this.FlourType?.ToLower())
            {
                case "white": modifier1 = 1.5;
                    break;
                case "wholegrain": modifier1 = 1.0;
                    break;
            }
            switch (this.BakingType?.ToLower())
            {
                case "chewy": modifier2 = 1.1;
                    break;
                case "crispy": modifier2 = 0.9;
                    break;
                case "homemade": modifier2 = 1.0;
                    break;
            }
            return (2 * this.Weight) * modifier1 * modifier2;
        }

        public override string ToString()
        {
            return $"{this.GetCalories():f2}";
        }
    }
}
