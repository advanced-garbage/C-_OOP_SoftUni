using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryDesignPattern.Classes;

namespace AbstractFactoryDesignPattern.Factories
{
    public class LandFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string name)
        {
            switch(name)
            {
                case "Dog": return new Dog();
                case "Cat": return new Cat();
                case "TurtlePope": return new TurtlePope();
                default: throw new ArgumentException("Wrong type! Did you mean 'Sea'?");
            }
        }
    }
}
