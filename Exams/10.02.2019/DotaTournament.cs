using System.Collections.Generic;
using System.Linq;

namespace _04.DotaTournament_10February2019
{
    using System;

    class DotaTournament
    {
        public class Team
        {
            public Team(string name, List<string> players)
            {
                Name = name;
                Players = players;
                Wins = 0;
            }
            public string Name { get; set; }
            public List<string> Players { get; set; }
            public int Wins { get; set; }
        }

        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Tournament end")
                {
                    break;
                }

                string[] commandLine = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string command = commandLine[0];
                string teamName = commandLine[1];

                switch (command)
                {
                    case "New team":
                        AddTeam(teamName, commandLine[2], teams);
                        break;
                    case "Disqualification":
                        RemoveTeam(teamName, teams);
                        break;
                    case "Win":
                        AddWin(teamName, teams);
                        break;
                }
            }
            Console.WriteLine("Teams:");
            foreach (var team in teams.OrderByDescending(t => t.Wins))
            {
                Console.WriteLine($"{team.Name} - {string.Join(", ", team.Players)} -> {team.Wins} wins");
            }


        }

        private static void RemoveTeam(string teamName, List<Team> teams)
        {
            if (IsTeamExist(teamName, teams))
            {
                Team teamToRemove = teams.First(t => t.Name == teamName);
                teams.Remove(teamToRemove);
            }
        }

        private static void AddTeam(string teamName, string playersInput, List<Team> teams)
        {
            List<string> players = playersInput.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            //Add only if players are 5 and team doesn't exist.
            if (players.Count == 5 && !IsTeamExist(teamName, teams))
            {
                Team team = new Team(teamName, players);
                teams.Add(team);
            }
        }

        private static void AddWin(string teamName, List<Team> teams)
        {
            if (IsTeamExist(teamName, teams))
            {
                teams.First(t => t.Name == teamName).Wins++;
            }
        }

        private static bool IsTeamExist(string teamName, List<Team> teams)
        {
            return teams.Any(t => t.Name == teamName);
        }
    }
}
