namespace _03.HeroProgress_27January2019
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class HeroProgress
    {
        public class Attack
        {
            public Attack(string type, long damage)
            {
                Type = type;
                Damage = damage;
            }
            public string Type { get; set; }
            public long Damage { get; set; }
        }

        public class Hero
        {
            public Hero(string name)
            {
                Name = name;
                Attacks = new List<Attack>();
            }
            public string Name { get; set; }
            public List<Attack> Attacks { get; set; }
        }


        static void Main(string[] args)
        {
            List<Hero> heroes = new List<Hero>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Fight")
                {
                    break;
                }

                string[] commandLine = input
                    .Split(new[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);

                string heroName = commandLine[0];

                if (commandLine.Length == 1)
                {
                    PrintHero(heroName, heroes);
                }
                else
                {
                    string attackType = commandLine[1];
                    long damage = long.Parse(commandLine[2]);

                    AddHero(heroName, attackType, damage, heroes);
                }
            }

            if (heroes.Count > 0)
            {
                PrintAllHeroes(heroes);
            }
        }

        private static void AddHero(string heroName, string attackType, long damage, List<Hero> heroes)
        {
            Hero hero = new Hero(heroName);

            if (heroes.All(h => h.Name != heroName))
            {
                heroes.Add(hero);
            }

            Attack attack = new Attack(attackType, damage);

            heroes.First(h => h.Name == heroName).Attacks.Add(attack);
        }

        private static void PrintHero(string heroName, List<Hero> heroes)
        {
            if (heroes.Any(h => h.Name == heroName))
            {
                Console.WriteLine($"^ {heroName}");

                foreach (var attack in heroes
                                            .First(h => h.Name == heroName)
                                            .Attacks)
                {
                    Console.WriteLine($"{attack.Type} <> {attack.Damage}");
                }
            }
            else
            {
                return;
            }
        }

        private static void PrintAllHeroes(List<Hero> heroes)
        {
            foreach (var hero in heroes)
            {
                Console.WriteLine($"^ {hero.Name}");

                foreach (var heroAttack in hero.Attacks.OrderByDescending(a => a.Damage))
                {
                    Console.WriteLine($"{heroAttack.Type} <> {heroAttack.Damage}");
                }
            }
        }
    }
}
