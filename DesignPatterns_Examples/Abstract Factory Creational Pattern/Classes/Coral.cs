using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Classes
{
    public class Coral : IAnimal
    {
        public string Speak()
        {
            return "Imma just a coral...";
        }
    }
}
