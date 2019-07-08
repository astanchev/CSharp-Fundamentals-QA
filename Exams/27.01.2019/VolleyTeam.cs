using System.Collections.Generic;
using System.Linq;

namespace _02.VolleyTeam_27January2019
{
    using System;

    class VolleyTeam
    {
        private static List<string> volleyTeam;
        static void Main(string[] args)
        {
            volleyTeam = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (volleyTeam.Count > 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }

                string[] commandLine = input.Split();
                string command = commandLine[0];
                string player = commandLine[1];

                switch (command)
                {
                    case "Add":
                        AddPlayer(player);
                        break;
                    case "Remove":
                        Remove(player);
                        break;
                    case "Change":
                        Change(player);
                        break;
                }
            }

            PrintTeam();
        }

        private static void PrintTeam()
        {
            if (volleyTeam.Count > 0)
            {
                Console.WriteLine(string.Join(", ", volleyTeam));
            }
            else
            {
                Console.WriteLine("There are no players left in the team.");
            }
        }

        private static void Change(string player)
        {
            string firstPlayer = player.Split('|')[0];
            string secondPlayer = player.Split('|')[1];

            if (volleyTeam.Contains(firstPlayer))
            {
                int index = volleyTeam.IndexOf(firstPlayer);
                volleyTeam[index] = secondPlayer;

                Console.WriteLine($"Successfully changed {firstPlayer} with {secondPlayer}.");
            }
            else
            {
                Console.WriteLine($"{firstPlayer} is not part of the team.");
            }
        }

        private static void Remove(string player)
        {
            if (volleyTeam.Contains(player))
            {
                volleyTeam.Remove(player);
                Console.WriteLine($"{player} has been removed.");
            }
            else
            {
                Console.WriteLine($"{player} is not part of the team.");
            }
        }

        private static void AddPlayer(string player)
        {
            if (volleyTeam.Contains(player))
            {
                Console.WriteLine($"{player} is already part of the team.");
            }
            else
            {
                volleyTeam.Add(player);
                Console.WriteLine($"{player} has been added to the team.");
            }
        }
    }
}
