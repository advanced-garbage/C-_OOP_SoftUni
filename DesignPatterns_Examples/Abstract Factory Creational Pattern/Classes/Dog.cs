using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Classes
{
    public class Dog : IAnimal
    {
        public string Speak()
        {
            return "woof woof lol";
        }
    }
}
