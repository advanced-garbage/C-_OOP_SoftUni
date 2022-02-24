using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string n, decimal p)
        {
            Name = n;
            Price = p;
        }
    }
}
