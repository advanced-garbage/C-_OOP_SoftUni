using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Factories
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(string name);

        public static AnimalFactory GetFactory(string factoryType)
        {
            switch (factoryType)
            {
                case "Sea": return new SeaFactory();
                case "Land": return new LandFactory();
                default:
                    throw new ArgumentException("Invalid input!");
            }
        }
    }
}
