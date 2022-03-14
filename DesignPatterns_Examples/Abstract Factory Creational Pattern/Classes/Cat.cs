using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Classes
{
    public class Cat : IAnimal
    {
        public string Speak()
        {
            return "mjau";
        }
    }
}
