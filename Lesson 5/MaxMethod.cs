using System;

namespace _07._Max_Method
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int maxNumber = GetMax(GetMax(firstNumber, secondNumber), thirdNumber);

            Console.WriteLine(maxNumber);
        }

        private static int GetMax(int a, int b)
        {
            if (a >= b) return a;
            else return b;
        }
    }
}
