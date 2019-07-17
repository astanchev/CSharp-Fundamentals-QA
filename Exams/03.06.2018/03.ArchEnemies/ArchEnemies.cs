namespace _03.ArchEnemies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class ArchEnemies
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> caseTimeHerlock = new Dictionary<string, long>();
            Dictionary<string, long> caseTimeMames = new Dictionary<string, long>();

            int numberCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberCases; i++)
            {
                string[] input = Console.ReadLine().Split(':');

                string caseName = input[0];
                long timeHerlock = long.Parse(input[1].TrimStart().Split()[0]);
                long timeMames = long.Parse(input[1].TrimStart().Split()[1]);

                if (timeHerlock == 0 
                    || timeMames == 0 )
                {
                    if (caseTimeMames.ContainsKey(caseName)
                        || caseTimeHerlock.ContainsKey(caseName))
                    {
                        caseTimeMames.Remove(caseName);
                        caseTimeHerlock.Remove(caseName);
                    }

                    continue;
                }

                if (!caseTimeHerlock.ContainsKey(caseName))
                {
                    caseTimeHerlock[caseName] = 0;
                }
                caseTimeHerlock[caseName] = timeHerlock;
                
                if (!caseTimeMames.ContainsKey(caseName))
                {
                    caseTimeMames[caseName] = 0;
                }
                caseTimeMames[caseName] = timeMames;


                if (caseTimeHerlock[caseName] == caseTimeMames[caseName])
                {
                    caseTimeHerlock.Remove(caseName);
                    caseTimeMames.Remove(caseName);
                }
            }

            Dictionary<string, long> resultHerlock = new Dictionary<string, long>();
            Dictionary<string, long> resultMames = new Dictionary<string, long>();

            foreach (var @case in caseTimeHerlock)
            {
                string caseName = @case.Key;

                if (caseTimeHerlock[caseName] < caseTimeMames[caseName])
                {
                    resultHerlock[caseName] = @case.Value;
                }
                else if (caseTimeHerlock[caseName] > caseTimeMames[caseName])
                {
                    resultMames[caseName] = caseTimeMames[caseName];
                }
            }

            Console.WriteLine("Herlock's Cases:");
            foreach (var @case in resultHerlock.OrderBy(c => c.Key))
            {
                Console.WriteLine($"-- {@case.Key}: {@case.Value}s.");
            }

            Console.WriteLine();

            Console.WriteLine("Mames's Cases:");
            foreach (var @case in resultMames.OrderBy(c => c.Key))
            {
                Console.WriteLine($"-- {@case.Key}: {@case.Value}s.");
            }

            Console.WriteLine();
            long totalTimeHerlock = caseTimeHerlock.Sum(t => t.Value);
            long totalTimeMames = caseTimeMames.Sum(t => t.Value);

            if (totalTimeMames < totalTimeHerlock)
            {
                Console.WriteLine("The winner is: Mames");
            }
            else if (totalTimeMames > totalTimeHerlock)
            {
                Console.WriteLine("The winner is: Herlock");
            }
            else if (totalTimeMames == totalTimeHerlock)
            {
                Console.WriteLine("No winner.");
            }
        }
    }
}
