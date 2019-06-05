using System;
using System.Collections.Generic;
using System.Linq;

namespace _24._Search_for_a_Number
{
    class SearchforaNumber
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            int[] manipulations = Console.ReadLine()
                                         .Split()
                                         .Select(int.Parse)
                                         .ToArray();
            
            int takeNumbers = manipulations[0];
            int deleteNumbers = manipulations[1];
            int targetNumber = manipulations[2];

            if (takeNumbers > input.Count || deleteNumbers > takeNumbers)
            {
                Console.WriteLine("NO!");
                return;
            }

            List<int> result = input.Take(takeNumbers).Skip(deleteNumbers).ToList();

            if (result.Contains(targetNumber))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
