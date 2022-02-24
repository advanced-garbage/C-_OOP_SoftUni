using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        public double Caffeine { get; set; }
        public double CoffeeMilliliters { get; set; }
        public decimal CoffeePrice { get; set; }

        public Coffee(string n, decimal p, double mm) : base(n, p, mm)
        {
            CoffeeMilliliters = 50;
            CoffeePrice = 3.50m;
        }
    }
}
