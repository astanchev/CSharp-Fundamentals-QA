using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Logs_Aggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string,int>> userIPDuration = 
                new Dictionary<string, Dictionary<string, int>>();

            int numberLogs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberLogs; i++)
            {
                string[] input = Console.ReadLine().Split();

                string ip = input[0];
                string user = input[1];
                int duration = int.Parse(input[2]);

                if (!userIPDuration.ContainsKey(user))
                {
                    userIPDuration[user] = new Dictionary<string, int>();
                }

                if (!userIPDuration[user].ContainsKey(ip))
                {
                    userIPDuration[user][ip] = 0;
                }

                userIPDuration[user][ip] += duration;
            }

            foreach (var user in userIPDuration.OrderBy(u => u.Key))
            {
                Console.WriteLine($"{user.Key}: {user.Value.Values.Sum()} " +
                                  $"[{string.Join(", ", user.Value.Keys.ToList().OrderBy(x => x))}]");
            }
        }
    }
}
