using Hero.Factories;

namespace Hero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                BaseHero hero = null;
                try
                {
                    hero = HeroesFactory.CreateHero(heroType, heroName);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }

                if (hero != null)
                {
                    heroes.Add(hero);
                }
                
            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach (BaseHero hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }

            if (CanWin(bossPower, heroes))
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        private static bool CanWin(int bossPower, List<BaseHero> heroes)
        {
            int totalPower = heroes.Sum(hero => hero.Power);

            return totalPower >= bossPower;
        }

    }
}
