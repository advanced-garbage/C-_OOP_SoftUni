using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public abstract class BaseHero
    {
        public string Name { get; set; }
        public int Power { get; set; }

        public BaseHero(string name)
        {
            this.Name = name;
        }

        public string CastAbility()
        {
            switch (this.GetType().Name)
            {
                case "Druid":
                case "Paladin":
                    return $"{this.GetType().Name} - {this.Name} healed for {this.Power}"; break;
                case "Rogue":
                case "Warrior":
                    return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage"; break;
                default:
                    return null;
            }
        }
    }
}
