using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class BaseHeroFactory
    {
        public static BaseHero CreateHero(string heroName, string heroType)
        {
            BaseHero bh = null;
            switch (heroType?.ToLower())
            {
                case "paladin": bh = new Paladin(heroName); break;
                case "druid": bh = new Druid(heroName); break;
                case "rogue": bh = new Rogue(heroName); break;
                case "warrior": bh = new Warrior(heroName); break;
            }
            return bh;
        }
    }
}
