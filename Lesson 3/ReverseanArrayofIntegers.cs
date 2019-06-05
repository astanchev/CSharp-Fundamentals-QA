using System;

namespace _02._Reverse_an_Array_of_Integers
{
    class ReverseanArrayofIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = n - 1; i >= 0; i--)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
