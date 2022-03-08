using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Vehicle car = new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2]));
            string[] truckArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Vehicle truck = new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2]));
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (commArgs[0]?.ToLower()) {
                    case "drive":
                        switch (commArgs[1]?.ToLower()) {
                            case "car": car.Drive(double.Parse(commArgs[2]));
                                break;
                            case "truck": truck.Drive(double.Parse(commArgs[2]));
                                break; }
                        break;
                    case "refuel": 
                        switch (commArgs[1]?.ToLower()) {
                            case "car": car.Refuel(double.Parse(commArgs[2]));
                                break;
                            case "truck": truck.Refuel(double.Parse(commArgs[2]));
                                break; }
                        break; }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
        }
    }
}
