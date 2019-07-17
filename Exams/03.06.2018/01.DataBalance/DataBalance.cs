namespace _01.DataBalance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DataBalance
    {
        static void Main(string[] args)
        {
            List<int> averageValues = new List<int>();
            int numberArrays = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberArrays; i++)
            {
                double[] inputArray = Console.ReadLine()
                    .Split(new[] { " "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                int averageValueArray = (int)Math.Ceiling(inputArray.Average());

                averageValues.Add(averageValueArray);
            }

            int divider = int.Parse(Console.ReadLine());

            for (int i = 0; i < averageValues.Count; i++)
            {
                if (averageValues[i] == 0)
                {
                    continue;
                }

                if (averageValues[i] % divider == 0)
                {
                    averageValues.RemoveAt(i);
                    i--;
                }
            }

            int minValue = averageValues.Min();

            if (minValue == 0)
            {
                Console.WriteLine($"The inputs seem to be perfectly balanced, as all things should be. Count of all arrays: {numberArrays}.");
            }
            else if (minValue > 0)
            {
                Console.WriteLine($"The inputs seem to be positively weighted. Positive weight: {minValue}");
            }
            else if (minValue < 0)
            {
                Console.WriteLine($"The inputs seem to be negatively weighted. Negative weight: {minValue}");
            }
        }
    }
}
