using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private int money;
        private List<Product> products;
        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
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
        public int Money
        {
            get { return this.money; }
            private set
            {
                try
                {
                    if (value < 0)
                        throw new ArgumentException();
                    this.money = value;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Money cannot be negative");
                    Environment.Exit(0);
                }
            }
        }
        public IReadOnlyCollection<Product> Products
        {
            get { return this.products.AsReadOnly(); }
        }

        public void AddProduct(Product product)
        {
            if (product.Cost > this.Money)
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            else
            {
                this.products.Add(product);
                this.Money -= product.Cost;
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
        }

        public string PrintProducts()
        {
            var sb = new StringBuilder();
            sb.Append($"{this.Name} - ");
            foreach (Product product in this.Products)
                sb.Append($"{product.Name}, ");
            sb.Remove(sb.Length - 2, 1);  
            return sb.ToString().TrimEnd();
        }
    }
}
