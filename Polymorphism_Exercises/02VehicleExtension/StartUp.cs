using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Vehicle car = new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2]), double.Parse(carArgs[3]));
            string[] truckArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Vehicle truck = new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2]), double.Parse(truckArgs[3]));
            string[] busArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Vehicle bus = new Bus(double.Parse(busArgs[1]), double.Parse(busArgs[2]), double.Parse(busArgs[3]));
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (commArgs[0]?.ToLower()) {
                    case "drive":
                        switch (commArgs[1]?.ToLower()) {
                            case "car": car.Drive(double.Parse(commArgs[2])); break;
                            case "truck": truck.Drive(double.Parse(commArgs[2])); break;
                            case "bus": bus.Drive(double.Parse(commArgs[2]), false); break; }
                        break;
                    case "refuel": 
                        switch (commArgs[1]?.ToLower()) {
                            case "car": car.Refuel(double.Parse(commArgs[2])); break;
                            case "truck": truck.Refuel(double.Parse(commArgs[2])); break;
                            case "bus": bus.Refuel(double.Parse(commArgs[2])); break; }
                        break;
                    case "driveempty": bus.Drive(double.Parse(commArgs[2]), true); break;
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }
    }
}
