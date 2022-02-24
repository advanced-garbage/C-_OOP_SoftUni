using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Dessert : Food
    {
        public double Calories { get; set; }
        public Dessert(string n, decimal p, double g, double c) : base(n, p, g) {
            Calories = c;
        }
    }
}
