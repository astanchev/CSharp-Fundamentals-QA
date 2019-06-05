using System;
using System.Linq;

namespace _13._Max_Sequence_of_Increasing_Elements
{
    class MaxSequenceofIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int endIndex = -1;
            int currentLenght = 1;
            int maxLenght = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] > array[i])
                {
                    currentLenght++;
                }
                else
                {
                    currentLenght = 1;
                }

                if (currentLenght > maxLenght)
                {
                    maxLenght = currentLenght;
                    endIndex = i+1;
                }
            }

            int br = 0;
            for (int i = endIndex - maxLenght + 1; i <= endIndex; i++)
            {
                if (br>0)
                {
                    Console.Write($" ");
                }
                Console.Write($"{array[i]}");
                br++;
            }
        }
    }
}
