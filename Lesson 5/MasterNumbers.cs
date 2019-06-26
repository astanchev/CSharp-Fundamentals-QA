using System;
using System.Collections.Generic;

namespace _12._Master_Numbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNumber; i++)
            {
                if (IsPalindrome(i)
                    && SumOfDigits(i)
                    && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsEvenDigit(int number)
        {
            bool containsEven = false;

            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    containsEven = true;
                    break;
                }

                number /= 10;
            }

            return containsEven;
        }

        private static bool SumOfDigits(int number)
        {
            bool isSumDevisible = false;
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 7 == 0)
            {
                isSumDevisible = true;
            }

            return isSumDevisible;
        }

        private static bool IsPalindrome(int number)
        {
            bool isPalindrome = false;
            int reverse = 0;
            int temp = number;

            while (number != 0)
            {
                int remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }

            if (reverse == temp)
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }
    }
}
