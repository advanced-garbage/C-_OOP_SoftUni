using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string n, int a, string g) : base(n, a, g) { }

        public override string ProduceSound()
        {
            return "Meow meow";
        }
    }
}
