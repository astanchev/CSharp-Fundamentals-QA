using System.Collections.Generic;
using System.Linq;

namespace _02.HeroofEldevir_10February2019
{
    using System;

    class HeroofEldevir
    {
        private static List<string> inventory;
        static void Main(string[] args)
        {
            inventory = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            while (inventory.Count > 0)
            {
                string[] inputLine = Console.ReadLine().Split();
                if (inputLine[0] == "Battle")
                {
                    break;
                }

                string command = inputLine[0];
                string item = inputLine[1];

                switch (command)
                {
                    case "Loot":
                        AddItem(item);
                        break;
                    case "Disenchant":
                        RemoveItem(item);
                        break;
                    case "Upgrade":
                        UpgradeItem(item);
                        break;
                }
            }

            if (inventory.Count > 0)
            {
                PrintInventory();
            }
        }

        private static void PrintInventory()
        {
            Console.WriteLine("Red Paladin's inventory :");

            foreach (var item in inventory)
            {
                Console.WriteLine($"--> {item}");
            }

        }

        private static void UpgradeItem(string item)
        {
            string firstItem = item.Split('/')[0];
            string secondItem = item.Split('/')[1];

            if (inventory.Contains(firstItem))
            {
                string result = firstItem + " ~ " + secondItem;
                int indexOfFirst = inventory.IndexOf(firstItem);

                inventory[indexOfFirst] = result;

                Console.WriteLine($"{firstItem} has been upgraded to {result}.");

            }

        }

        private static void RemoveItem(string item)
        {
            if (!inventory.Contains(item))
            {
                return;
            }

            inventory.Remove(item);

            if (inventory.Count == 0)
            {
                Console.WriteLine("The inventory is empty.");
            }
            else
            {
                Console.WriteLine($"{item} has been disenchanted.");
            }

        }

        private static void AddItem(string item)
        {
            if (!inventory.Contains(item))
            {
                inventory.Add(item);
                Console.WriteLine($"{item} has been added to the inventory.");
            }
        }

    }
}
