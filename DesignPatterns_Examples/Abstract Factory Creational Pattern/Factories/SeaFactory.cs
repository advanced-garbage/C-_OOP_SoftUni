using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryDesignPattern.Classes;

namespace AbstractFactoryDesignPattern.Factories
{
    public class SeaFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string name)
        {
            switch(name)
            {
                case "Octopus": return new Octopus();
                case "Coral": return new Coral();
                default: throw new ArgumentException("Wrong type! Did you mean 'Land?'");
            }
        }
    }
}
