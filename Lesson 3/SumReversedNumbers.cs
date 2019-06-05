using System;
using System.Collections.Generic;
using System.Linq;

namespace _25._Sum_Reversed_Numbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            foreach (var number in input)
            {
                char[] arr = number.ToString().ToCharArray();

                Array.Reverse(arr);

                int newNumber = int.Parse(new string(arr));
                result.Add(newNumber);
            }

            Console.WriteLine(result.Sum());
        }
    }
}
