using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        public string Name { get; set; }   
        public int Age { get; set; }
        public string Gender { get; set; }

        public Animal(string n, int a, string g)
        {
            Name = n;
            Age = a;
            Gender = g;
        }

        public virtual string ProduceSound()
        {
            return "";
        }
    }
}
