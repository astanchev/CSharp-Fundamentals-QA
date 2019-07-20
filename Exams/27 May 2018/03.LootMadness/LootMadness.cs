namespace _03.LootMadness_27May2018
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    class LootMadness
    {
        class Item
        {
            public Item(string name, string quality, ulong gold, decimal healthBonus)
            {
                this.Name = name;
                this.Quality = quality;
                this.Gold = gold;
                this.HealthBonus = healthBonus;
            }
            public string Name { get; set; }
            public string Quality { get; set; }
            public ulong Gold { get; set; }
            public decimal HealthBonus { get; set; }
        }

        class Person
        {
            private const string NamePerson = "Marto";

            public Person(decimal health, ulong gold)
            {
                this.Health = health;
                this.Gold = gold;
                this.Items = new List<Item>();
            }

            public string Name => NamePerson;

            public decimal Health { get; set; }

            public ulong Gold { get; set; }

            public List<Item> Items { get; set; }
        
        }
        static void Main(string[] args)
        {
            ulong startingGold = ulong.Parse(Console.ReadLine());
            decimal startingHealth = decimal.Parse(Console.ReadLine());

            Person marto = new Person(startingHealth, startingGold);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "NO MORE LOOT")
                {
                    break;
                }

                string[] inputType = input.Split(':');

                string itemName = inputType[0];

                if (itemName == "Gold")
                {
                    marto.Gold += ulong.Parse(inputType[1].TrimStart());
                }
                else
                {
                    Item item = CreateItem(inputType, itemName);
                    
                    if (item.Quality != "Rare" && item.Quality !=  "Legendary")
                    {
                        marto.Gold += item.Gold;
                    }
                    else if (item.Quality == "Rare"
                        && marto.Items.Any(i => i.Name == item.Name))
                    {
                        marto.Gold += item.Gold;
                    }
                    else if (item.Quality == "Legendary"
                             && marto.Items.Any(i => i.Name == item.Name))
                    {
                        continue;
                    }
                    else
                    {
                        marto.Items.Add(item);

                        marto.Health += item.HealthBonus;
                    }
                }
            }

            PrintStats(marto);
        }

        private static Item CreateItem(string[] inputType, string itemName)
        {
            string[] itemArgs = inputType[1].TrimStart().Split();

            string itemQuality = itemArgs[0];
            ulong itemGold = ulong.Parse(itemArgs[1]);
            decimal itemHealthBonus = decimal.Parse(itemArgs[2]);

            Item item = new Item(itemName, itemQuality, itemGold, itemHealthBonus);
            return item;
        }

        private static void PrintStats(Person marto)
        {
            Console.WriteLine($"Marto has a total of {marto.Gold} gold.");
            Console.WriteLine($"Marto's total health is {marto.Health}.");
            Console.WriteLine("Marto has collected the following items:");

            foreach (var item in marto.Items)
            {
                Console.WriteLine($"> {item.Name} [Quality: {item.Quality}] [HP Bonus: {item.HealthBonus}]");
            }
        }
    }
}
