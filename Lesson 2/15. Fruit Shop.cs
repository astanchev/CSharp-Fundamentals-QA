using System;
using System.Linq;

namespace _15._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0.0;
            bool isValidData = true;

            string[] workingDays = { "monday", "tuesday", "wednesday", "thursday", "friday" };
            string[] weekend = { "saturday", "sunday" };

            if (workingDays.Contains(day))
            {
                switch (fruit)
                {
                    case "banana": price = 2.5; break;
                    case "apple": price = 1.2; break;
                    case "orange": price = 0.85; break;
                    case "grapefruit": price = 1.45; break;
                    case "kiwi": price = 2.7; break;
                    case "pineapple": price = 5.5; break;
                    case "grapes": price = 3.85; break;
                    default: isValidData = false; break;
                }
            }
            else if (weekend.Contains(day))
            {
                switch (fruit)
                {
                    case "banana": price = 2.7; break;
                    case "apple": price = 1.25; break;
                    case "orange": price = 0.9; break;
                    case "grapefruit": price = 1.6; break;
                    case "kiwi": price = 3.0; break;
                    case "pineapple": price = 5.6; break;
                    case "grapes": price = 4.2; break;
                    default: isValidData = false; break;
                }
            }
            else
            {
                isValidData = false;
            }

            if (isValidData)
            {
                Console.WriteLine($"{price*quantity:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
