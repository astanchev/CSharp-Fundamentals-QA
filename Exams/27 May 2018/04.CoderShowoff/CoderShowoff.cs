namespace _04.CoderShowoff_27May2018
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CoderShowoff
    {
        private static List<Coder> coders;
        class Coder
        {
            public Coder(string name, long stamina, long strength, long intellect, char rank, string guild)
            {
                this.Name = name;
                this.Stamina = stamina;
                this.Strength = strength;
                this.Intellect = intellect;
                this.Rank = rank;
                this.Guild = guild;
            }
            public string Name { get; set; }
            public long Stamina { get; set; }
            public long Strength { get; set; }
            public long Intellect { get; set; }
            public char Rank { get; set; }
            public string Guild { get; set; }

        }
        static void Main(string[] args)
        {
            coders = new List<Coder>();

            int numberPlayers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberPlayers; i++)
            {
                string[] coderArgs = Console.ReadLine().Split('|');

                string name = coderArgs[0];
                long stamina = long.Parse(coderArgs[1]);
                long strength = long.Parse(coderArgs[2]);
                long intellect = long.Parse(coderArgs[3]);
                char rank = char.Parse(coderArgs[4]);
                string guild = coderArgs[5];

                if (stamina <= 0
                    || strength <= 0
                    || intellect <= 0)
                {
                    continue;
                }

                Coder coder = new Coder(name,
                                        stamina,
                                        strength,
                                        intellect,
                                        rank,
                                        guild);

                coders.Add(coder);
            }

            Coder mostEnduringCoder = coders
                                      .OrderByDescending(c => c.Stamina)
                                      .First(); 
            
            Coder weakestCoder = coders
                                    .OrderByDescending(c => c.Strength)
                                    .Last(); 
            
            Coder wisestCoder = coders
                                    .OrderByDescending(c => c.Intellect)
                                    .First();

            long totalEndurance = coders.Sum(c => c.Stamina);
            long totalStrength = coders.Sum(c => c.Strength);
            long totalIntellect = coders.Sum(c => c.Intellect);

            Console.WriteLine($"Most endurable player is: {mostEnduringCoder.Name} with rank {mostEnduringCoder.Rank} from guild {mostEnduringCoder.Guild}");

            Console.WriteLine($"Weakest player is: {weakestCoder.Name} with rank {weakestCoder.Rank} from guild {weakestCoder.Guild}");

            Console.WriteLine($"Wisest player is: {wisestCoder.Name} with rank {wisestCoder.Rank} from guild {wisestCoder.Guild}");

            Console.WriteLine($"Total Endurance {totalEndurance}");
            Console.WriteLine($"Total Strength {totalStrength}");
            Console.WriteLine($"Total Intellect {totalIntellect}");

        }
    }
}
