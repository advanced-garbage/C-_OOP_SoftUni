using System;
using PrototypeDesignPattern.PrototypeClasses;

namespace PrototypeDesignPattern
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("1");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine($"Cloned: {c1.Id}");

            ConcretePrototype2 p2 = new ConcretePrototype2("2");   
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine($"Cloned: {c2.Id}");
        }
    }
}
