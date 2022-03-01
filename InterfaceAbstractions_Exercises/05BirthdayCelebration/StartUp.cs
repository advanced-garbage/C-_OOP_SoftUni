using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            IIdentification id_obj = null;
            IBirthday bd_obj = null;
            var id_members = new List<IIdentification>();
            var bd_members = new List<IBirthday>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] dataArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch(dataArgs[0]?.ToLower())
                {
                    case "pet":
                        bd_obj = new Pet(dataArgs[1], dataArgs[2]);
                        bd_members.Add(bd_obj);
                        break;
                    case "robot":
                        id_obj = new Robot(dataArgs[1], dataArgs[2]);  
                        id_members.Add(id_obj);
                        break;
                    case "citizen":
                        bd_obj = new Citizen(dataArgs[1], int.Parse(dataArgs[2]), dataArgs[3], dataArgs[4]);
                        bd_members.Add(bd_obj);
                        break;
                }
            }
            string year = Console.ReadLine();
            foreach (var birthdayBoy in bd_members)
            {
                string getYear = birthdayBoy.Birthday.Split('/').ToList().Last();
                if (getYear.Equals(year)) birthdayBoy.PrintBirthday();
            }
        }
    }
}
