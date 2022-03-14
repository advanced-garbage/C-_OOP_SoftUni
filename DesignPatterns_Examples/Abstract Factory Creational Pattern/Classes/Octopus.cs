using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Classes
{
    public class Octopus : IAnimal
    {
        public string Speak()
        {
            return "SQUAWCK";
        }
    }
}
