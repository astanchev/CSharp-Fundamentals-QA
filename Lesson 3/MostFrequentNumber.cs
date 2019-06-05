using System;
using System.Linq;

namespace _14._Most_Frequent_Number
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int mostFrequent = 0;
            int countMostFrequent = 1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int currentNumber = arr[i];
                int countCurrent = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == currentNumber)
                    {
                        countCurrent++;
                    }

                    if (countCurrent > countMostFrequent)
                    {
                        countMostFrequent = countCurrent;
                        mostFrequent = currentNumber;
                    }
                }
            }

            if (countMostFrequent > 1)
            {
                Console.WriteLine(mostFrequent);
            }
            else
            {
                Console.WriteLine(arr[0]);
            }
            
        }
    }
}
