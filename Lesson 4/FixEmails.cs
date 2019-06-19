using System;
using System.Collections.Generic;

namespace _06._Fix_Emails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> nameEmail = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();
                if (email == "stop")
                {
                    break;
                }

                if (email.EndsWith(".us") || email.EndsWith(".uk"))
                {
                    continue;
                }

                if (!nameEmail.ContainsKey(name))
                {
                    nameEmail[name] = email;
                }
            }

            if (nameEmail.Count > 0)
            {
                foreach (var name in nameEmail)
                {
                    Console.WriteLine($"{name.Key} -> {name.Value}");
                }
            }
        }
    }
}
