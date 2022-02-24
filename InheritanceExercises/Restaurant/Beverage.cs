using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Beverage : Product
    {
        public double Milliliters { get; set; }

        public Beverage(string n, decimal p, double mm) : base(n, p)
        {
            Milliliters = mm;
        }
    }
}
