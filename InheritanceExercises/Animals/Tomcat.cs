using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string n, int a, string g) : base(n, a, "Male") { }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
