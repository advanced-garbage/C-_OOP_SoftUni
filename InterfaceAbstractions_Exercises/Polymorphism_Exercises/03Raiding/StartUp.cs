using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int heroCounter = 0;
            var heroes = new List<BaseHero>();
            int n = int.Parse(Console.ReadLine());

            while (heroCounter < n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                BaseHero currentBH = BaseHeroFactory.CreateHero(name, type);
                if (currentBH == null) {
                    Console.WriteLine("Invalid hero!");
                    continue; }

                heroes.Add(currentBH);
                heroCounter++;
            }

            foreach (var hero in heroes)
                Console.WriteLine(hero.CastAbility());

            Output(heroes.Sum(x => x.Power), int.Parse(Console.ReadLine()));
        }

        public static void Output(int sum, int bossHP)
        {
            if (sum >= bossHP)
                Console.WriteLine("Victory!");
            else
                Console.WriteLine("Defeat...");

            Environment.Exit(0);
        }
    }
}
