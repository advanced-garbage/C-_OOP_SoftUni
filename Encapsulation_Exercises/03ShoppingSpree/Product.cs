using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private int cost;
        public Product(string name, int cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                try
                {
                    if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                        throw new ArgumentNullException();
                    this.name = value;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Name cannot be empty");
                    Environment.Exit(0);
                }
            }
        }
        public int Cost
        {
            get { return this.cost; }
            set {
                try
                {
                    if (value < 0)
                        throw new ArgumentException();
                    this.cost = value;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Money cannot be negative");
                    Environment.Exit(0);
                }
            }
        }
    }
}
