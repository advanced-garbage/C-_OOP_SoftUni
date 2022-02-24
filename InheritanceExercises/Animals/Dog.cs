
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string n, int a, string g) : base(n, a, g) { }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
