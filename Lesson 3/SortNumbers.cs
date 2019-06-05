using System;
using System.Collections.Generic;
using System.Linq;

namespace _22._Sort_Numbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            input.Sort();
            Console.WriteLine(string.Join(" <= ", input));
        }
    }
}
