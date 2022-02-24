using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten : Cat
    {
        public Kitten(string n, int a, string g) : base(n, a, "Female") { }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
