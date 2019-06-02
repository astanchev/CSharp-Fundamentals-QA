using System;

namespace _27._Sequence_2k_plus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;

            while (true)
            {
                if (num > n)
                {
                    break;
                }

                Console.WriteLine(num);
                num = 2 * num + 1;
            }
        }
    }
}
