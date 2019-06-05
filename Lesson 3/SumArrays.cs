using System;
using System.Linq;

namespace _04._Sum_Arrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxLenght = Math.Max(arr1.Length, arr2.Length);
            int[] result = new int[maxLenght];

            for (int i = 0; i < maxLenght; i++)
            {
                if (i > arr1.Length - 1)
                {
                    result[i] = arr1[i % arr1.Length] + arr2[i];
                }
                else if (i > arr2.Length - 1)
                {
                    result[i] = arr2[i % arr2.Length] + arr1[i];
                }
                else
                {
                    result[i] = arr2[i] + arr1[i];
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
