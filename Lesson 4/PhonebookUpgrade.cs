using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Phonebook_Upgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> namePhone = new Dictionary<string, string>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "END")
                {
                    return;
                }
                else if (input[0] == "A")
                {
                    string name = input[1];
                    string phone = input[2];

                    if (!namePhone.ContainsKey(name))
                    {
                        namePhone[name] = String.Empty;
                    }

                    namePhone[name] = phone;

                }
                else if (input[0] == "S")
                {
                    string name = input[1];

                    if (namePhone.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {namePhone[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var name in namePhone.OrderBy(n => n.Key))
                    {
                        Console.WriteLine($"{name.Key} -> {name.Value}");
                    }
                }
            }
        }
    }
}
