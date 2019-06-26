using System;

namespace _08._Prime_Checker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long inputNumber = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(inputNumber));
        }

        private static bool IsPrime(long number)
        {
            bool isPrime = true;
            if (number == 0 || number == 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            return isPrime;
        }
    }
}
