using System;
using AbstractFactoryDesignPattern.Classes;
using AbstractFactoryDesignPattern.Factories;

namespace AbstractFactoryDesignPattern
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                var animalFactory = AnimalFactory.GetFactory("Sea");
                IAnimal animal = animalFactory.GetAnimal("Octopus");
                Console.WriteLine(animal.Speak());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
