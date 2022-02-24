using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Fish : MainDish
    {
        public Fish (string n, decimal p, double g) : base(n, p, g)
        {
            Grams = 22;
        }
    }
}
