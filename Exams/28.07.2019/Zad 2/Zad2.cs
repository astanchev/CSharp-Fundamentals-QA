namespace Zad2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Zad2
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop playing")
                {
                    break;
                }

                int[] inputList = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                
                HashSet<int> checkList = new HashSet<int>(inputList);

                bool areUnique = inputList.Length == checkList.Count;

                if (areUnique)
                {
                    for (int i = 0; i < inputList.Length; i++)
                    {
                        if (inputList[i] % 2 == 0)
                        {
                            inputList[i] += 2;
                        }
                    }

                    Array.Sort(inputList);

                    Console.WriteLine("Unique list: " + string.Join(",", inputList));
                }
                else
                {
                    for (int i = 0; i < inputList.Length; i++)
                    {
                        if (inputList[i] % 2 != 0)
                        {
                            inputList[i] += 3;
                        }
                    }

                    Array.Sort(inputList);

                    Console.WriteLine("Non-unique list: " + string.Join(":", inputList));
                }

                double sum = 1.0 * inputList.Sum() / inputList.Length;

                Console.WriteLine($"Output: {sum:f2}");
            }
        }
    }
}
