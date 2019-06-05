using System;
using System.Collections.Generic;
using System.Linq;

namespace _23._Square_Numbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> result = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (Math.Sqrt(input[i]) == (int)Math.Sqrt(input[i]))
                {
                    result.Add(input[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result
                                                        .OrderByDescending(x => x)));
        }
    }
}
