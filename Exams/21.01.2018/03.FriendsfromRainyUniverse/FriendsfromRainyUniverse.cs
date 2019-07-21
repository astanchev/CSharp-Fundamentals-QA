namespace _03.FriendsfromRainyUniverse_21January2018
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class FriendsfromRainyUniverse
    {
        private static Dictionary<string, Dictionary<string, int>> personLiquidJars;
        static void Main(string[] args)
        {
            personLiquidJars = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                CollectData(input);
            }

            PrintPersons();
        }

        private static void CollectData(string input)
        {
            string[] personData = input
                .Split(new[] {" -> ", ": "}, StringSplitOptions.RemoveEmptyEntries);

            string name = personData[0];
            string liquid = personData[1];
            int jarsCount = int.Parse(personData[2]);

            if (!personLiquidJars.ContainsKey(name))
            {
                personLiquidJars[name] = new Dictionary<string, int>();
            }

            if (!personLiquidJars[name].ContainsKey(liquid))
            {
                personLiquidJars[name][liquid] = 0;
            }

            personLiquidJars[name][liquid] += jarsCount;
        }

        private static void PrintPersons()
        {
            foreach (var person in personLiquidJars.OrderBy(p => p.Key))
            {
                Console.WriteLine($"{person.Key} Liquids:");

                foreach (var liquid in person.Value.OrderBy(l => l.Value))
                {
                    Console.WriteLine($"--- {liquid.Key}: {liquid.Value}");
                }
            }
        }
    }
}
