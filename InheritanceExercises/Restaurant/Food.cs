using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Food : Product
    {
        public double Grams { get; set; }

        public Food(string n, decimal p, double g) : base(n, p)
        {
            Grams = g;
        }

    }
}
