using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Frog : Animal
    {
        public Frog(string n, int a, string g) : base(n, a, g) { }

        public override string ProduceSound()
        {
            return "Ribbit";
        }
    }
}
