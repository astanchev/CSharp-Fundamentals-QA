using System;

namespace _28._Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 2;
            decimal sum = 1;

            while (i <= n)
            {
                sum = sum * i;
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
