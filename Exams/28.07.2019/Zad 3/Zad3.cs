namespace Zad3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Zad3
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> userPoints = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exam finished")
                {
                    break;
                }

                string[] inputLine = input
                    .Split(new[] {"<>"}, StringSplitOptions.RemoveEmptyEntries);

                string user = inputLine[0];
               
                if (user == "ban")
                {
                    string userToBan = inputLine[1];

                    if (userPoints.ContainsKey(userToBan))
                    {
                        userPoints.Remove(userToBan);
                    }
                }
                else
                {
                    int points = int.Parse(inputLine[1]);

                    if (!userPoints.ContainsKey(user))
                    {
                        userPoints[user] = points;
                    }
                    else
                    {
                        if (points > userPoints[user])
                        {
                            userPoints[user] = points;
                        }
                    }
                }
            }

            Console.WriteLine("Results:");

            foreach (var user in userPoints
                                    .OrderByDescending(u => u.Value)
                                    .ThenBy(u => u.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }

        }
    }
}
