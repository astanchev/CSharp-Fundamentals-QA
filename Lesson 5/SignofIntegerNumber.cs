using System;

namespace _02._Sign_of_Integer_Number
{
    class SignofIntegerNumber
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            PrintSign(inputNumber);
        }

        private static void PrintSign(int inputNumber)
        {
            string sign = String.Empty;

            if (inputNumber == 0)
            {
                sign = "zero";
            }
            else if (inputNumber > 0)
            {
                sign = "positive";
            }
            else if (inputNumber < 0)
            {
                sign = "negative";
            }

            Console.WriteLine($"The number {inputNumber} is {sign}.");
        }
    }
}
