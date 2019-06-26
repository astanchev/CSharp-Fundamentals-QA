using System;
using System.Collections.Generic;

namespace _09._Primes_in_Given_Range
{
    class PrimesinGivenRange
    {
        static void Main(string[] args)
        {
            int inputStartNumber = int.Parse(Console.ReadLine());
            int inputEndNumber = int.Parse(Console.ReadLine());

            List<int> result = FindPrimesInRange(inputStartNumber, inputEndNumber);

            Console.WriteLine(string.Join(", ", result));
        }

        private static List<int> FindPrimesInRange(int start, int end)
        {
            List<int> resultList = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    resultList.Add(i);
                }
            }

            return resultList;
        }

        private static bool IsPrime(int number)
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
