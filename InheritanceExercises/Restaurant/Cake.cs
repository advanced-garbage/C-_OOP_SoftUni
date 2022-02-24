using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        public decimal CakePrice { get; set; }
        public Cake(string n, decimal p, double g, double c): base(n, p, g, c)
        {
            Grams = 250;
            Calories = 1000;
            CakePrice = 5;
        }
    }
}
