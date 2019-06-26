using System;
using System.Numerics;

namespace _14._Factorial_Trailing_Zeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int zeroes = CountZeroes(Factorial(n));

            Console.WriteLine(zeroes);
        }

        private static int CountZeroes(BigInteger factorial)
        {
            string number = factorial.ToString();
            int count = 0;

            for (int i = number.Length -1; i >= 0; i--)
            {
                if (number[i] == '0')
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }

        static BigInteger Factorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
