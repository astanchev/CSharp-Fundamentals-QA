using System;
using System.Linq;

namespace _03._Triple_Sum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isSum = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int a = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int b = arr[j];
                    int currentSum = a + b;

                    for (int k = 0; k < arr.Length; k++)
                    {
                        int c = arr[k];
                        if (c == currentSum)
                        {
                            Console.WriteLine($"{a} + {b} == {c}");
                            isSum = true;
                        }
                    }

                }
            }

            if (isSum == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
