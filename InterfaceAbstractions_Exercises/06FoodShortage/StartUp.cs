using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Citizen citizen_obj = null;
            Rebel rebel_obj = null;
            var citizen_members = new List<Citizen>();
            var rebel_members = new List<Rebel>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] dataArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (dataArgs.Length == 4) {
                    citizen_obj = new Citizen(dataArgs[0], int.Parse(dataArgs[1]), dataArgs[2], dataArgs[3]);
                    citizen_members.Add(citizen_obj);
                } else if (dataArgs.Length == 3) {
                    rebel_obj = new Rebel(dataArgs[0], int.Parse(dataArgs[1]), dataArgs[2]);
                    rebel_members.Add(rebel_obj); }
            }

            string name;
            while ((name = Console.ReadLine()) != "End")
            {
                if (citizen_members.Any(x => x.Name.Equals(name))) {
                    citizen_members.Find(x => x.Name.Equals(name)).BuyFood();
                    continue; }

                if (rebel_members.Any(y => y.Name.Equals(name))) {
                    rebel_members.Find(x => x.Name.Equals(name)).BuyFood(); }
            }

            Console.WriteLine(citizen_members.Sum(x => x.Food) + rebel_members.Sum(x => x.Food));
        }
    }
}
