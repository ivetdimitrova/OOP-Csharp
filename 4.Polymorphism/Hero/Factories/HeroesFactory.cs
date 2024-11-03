using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero.Factories
{
    public class HeroesFactory
    {
        public static BaseHero CreateHero (string heroType, string heroName)
        {
            switch (heroType)
            {
                case "Druid":
                    return new Druid(heroName);
                case "Paladin":
                    return new Paladin(heroName);
                case "Rogue":
                    return new Rogue(heroName);
                case "Warrior":
                    return new Warrior(heroName);
                default:
                    throw new ArgumentException("Invalid hero!");
            }

        }
    }
}
