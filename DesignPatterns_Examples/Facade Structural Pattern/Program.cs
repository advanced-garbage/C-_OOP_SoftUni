using System;
using Facade.FacadeClass;
namespace Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car = new CarBuilderFacade()
                .Info
                    .WithType("Honda")
                    .WithColor("Grey")
                    .WithNumOfDoors(4)
                .City
                    .WithCity("Burgas")
                    .WithAddress("Lazur lol")
                .Build();

            Console.WriteLine(car);
            
        }
    }
}
