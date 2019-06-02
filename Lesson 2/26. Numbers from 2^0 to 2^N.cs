using System;

namespace _26._Numbers_from_2_0_to_2_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(Math.Pow(2,i));
            }
        }
    }
}
