using System;
using System.Linq;

namespace ExtractMiddle1_2or3Elements
{
    class ExtractMiddle1_2Or3Elements
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (arr.Length == 1)
            {
                Console.WriteLine($"{{ {arr[0]} }}");
            }
            else if (arr.Length % 2 == 0)
            {
                Console.WriteLine($"{{ {arr[arr.Length/2 - 1]}, {arr[arr.Length/2]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {arr[arr.Length/2 - 1]}, {arr[arr.Length/2]}, {arr[arr.Length/2 + 1]} }}");
            }
        }
    }
}
