using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _04.MindPalace
{
    using System;

    class MindPalace
    {
        public class Chest
        {
            public Chest(string name, string description, string category)
            {
                Name = name;
                Description = description;
                Category = category;
                this.Items = new List<Item>();
            }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public List<Item> Items { get; set; }
        }

        public class Item
        {
            public Item(string name, DateTime acquiredDate, int importanceIndex)
            {
                Name = name;
                AcquiredDate = acquiredDate;
                ImportanceIndex = importanceIndex;
            }
            public string Name { get; set; }
            public DateTime AcquiredDate { get; set; }
            public int ImportanceIndex { get; set; }
        }
        static void Main(string[] args)
        {
            List<Chest> chests = new List<Chest>();

            while (true)
            {
                string[] inputLine = Console.ReadLine()
                    .Split(new[] {" - "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (inputLine[0] == "END")
                {
                    break;
                }

                if (inputLine.Length == 3)
                {
                    string chestName = inputLine[0];
                    string description = inputLine[1];
                    string category = inputLine[2];

                    Chest chest = new Chest(chestName, description, category);

                    chests.Add(chest);
                }
                else if (inputLine.Length == 4)
                {
                    string itemName = inputLine[0];
                    string chestName = inputLine[1];
                    DateTime acquiredDate = DateTime.ParseExact(inputLine[2], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    int importanceIndex = int.Parse(inputLine[3]);

                    Item item = new Item(itemName, acquiredDate, importanceIndex);

                    Chest chestToAdd = chests.FirstOrDefault(c => c.Name == chestName);

                    chestToAdd?.Items.Add(item);
                }
            }

            int countImportant = 0;

            Console.WriteLine("Herlock's Mind Palace:");
            Console.WriteLine();

            foreach (var chest in chests)
            {
                Console.WriteLine($"{chest.Name} - ({chest.Category})");
                Console.WriteLine($"-- {chest.Description}");

                foreach (var item in chest.Items.Where(i => i.AcquiredDate.Year > 2005 && i.ImportanceIndex >3))
                {
                    Console.WriteLine($"---- {item.Name}, acquired {item.AcquiredDate:MMMM} {item.AcquiredDate.Year}.");
                    countImportant++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Herlock's total items: {chests.Sum(c=>c.Items.Count)}");
            Console.WriteLine($"Herlock's important items: {countImportant}");
        }
    }
}
