using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Hands_of_Cards
{
    class HandsofCards
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> cardsType = new Dictionary<string, int>
            {
                { "S", 4},
                { "H", 3},
                { "D", 2},
                { "C", 1}
            };

            Dictionary<string, int> cardsPower = new Dictionary<string, int>
            {
                {"2", 2}, {"3", 3}, {"4", 4}, {"5", 5},{"6", 6},
                {"7", 7}, {"8", 8}, {"9", 9},{"10", 10}, {"J", 11},
                {"Q", 12}, {"K", 13}, {"A", 14}
            };

            Dictionary<string, HashSet<string>> nameCards = new Dictionary<string, HashSet<string>>();
            Dictionary<string, int> nameSum = new Dictionary<string, int>();


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "JOKER")
                {
                    break;
                }

                string[] inputLine = input
                    .Split(new char[]{':'}, StringSplitOptions.RemoveEmptyEntries);
                string name = inputLine[0];
                string[] inputCards = inputLine[1]
                    .Split(new char[]{',', ' '}, StringSplitOptions.RemoveEmptyEntries);

                if (!nameCards.ContainsKey(name))
                {
                    nameCards[name] = new HashSet<string>();
                }

                foreach (var card in inputCards)
                {
                    nameCards[name].Add(card);
                }
            }


            foreach (var name in nameCards)
            {
                int sum = 0;
                foreach (var card in name.Value)
                {
                    string power = String.Empty;
                    string type = String.Empty;

                    if (card.Length == 3)
                    {
                        power = card.Substring(0, 2);
                        type = card.Substring(2);
                    }
                    else
                    {
                        power = card.Substring(0, 1);
                        type = card.Substring(1);
                    }

                    sum += cardsPower[power] * cardsType[type];
                }

                nameSum[name.Key] = sum;
            }

            foreach (var name in nameSum)
            {
                Console.WriteLine($"{name.Key}: {name.Value}");
            }
        }
    }
}
