using System;
using System.Linq;

namespace _09._Rotate_and_Sum
{
    class RotateandSum
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberRotations = int.Parse(Console.ReadLine());
            int[] result = new int[array.Length];
            
            for (int i = 0; i < numberRotations; i++)
            {
                int tempLast = array[array.Length - 1];
                for (int j = array.Length - 1; j >= 1; j--)
                {
                    array[j] = array[j - 1];
                    result[j] += array[j];
                }
                array[0] = tempLast;
                result[0] += array[0];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
