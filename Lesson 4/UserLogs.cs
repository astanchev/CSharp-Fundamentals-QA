using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._User_Logs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> userIPMessages =
                new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, List<string>> nameIP = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "end")
                {
                    break;
                }

                string ip = input[0].Split('=')[1];
                string inputMessages = input[1].Split('=')[1];
                string user = input[2].Split('=')[1];

                if (!userIPMessages.ContainsKey(user))
                {
                    userIPMessages[user] = new Dictionary<string, int>();
                }

                if (!userIPMessages[user].ContainsKey(ip))
                {
                    userIPMessages[user][ip] = 0;
                }

                userIPMessages[user][ip]++;
            }

            foreach (var user in userIPMessages)
            {
                nameIP[user.Key] = new List<string>();
                foreach (var ip in user.Value)
                {
                    string ipMessagesCount = $"{ip.Key} => {ip.Value}";
                    nameIP[user.Key].Add(ipMessagesCount);
                }
            }

            foreach (var name in nameIP.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{name.Key}:");
                Console.WriteLine(string.Join(", ", name.Value) + ".");
            }
        }
    }
}
