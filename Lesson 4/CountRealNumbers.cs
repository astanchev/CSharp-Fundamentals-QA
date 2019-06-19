﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> count = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!count.ContainsKey(number))
                {
                    count[number] = 0;
                }
                count[number]++;
            }

            foreach (var kvp in count)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
