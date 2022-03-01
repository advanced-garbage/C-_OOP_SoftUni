using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            IIdentification obj = null;
            var members = new List<IIdentification>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] dataArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (dataArgs.Length == 3)  {
                    obj = new Citizen(dataArgs[0], int.Parse(dataArgs[1]), dataArgs[2]);   
                } else if (dataArgs.Length == 2)  {
                    obj = new Robot(dataArgs[0], dataArgs[1]); }
                members.Add(obj);
            }

            string catchId = Console.ReadLine();
            foreach (var member in members) {
                if (member.Id.Length >= catchId.Length &&
                    member.Id.Substring(member.Id.Length - catchId.Length, catchId.Length).Equals(catchId)) {
                    member.PrintFakeIDs(); }
            }
        }
    }
}
