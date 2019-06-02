using System;

namespace _33._Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            int maxPairDiff = 0;

            for (int i = 1; i < n; i++)
            {
                int oldDiff = sum;

                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                sum = num1 + num2;
                if (sum != oldDiff)
                {
                    int currentPairDiff = Math.Abs(sum - oldDiff);
                    if (currentPairDiff > maxPairDiff)
                    {
                        maxPairDiff = currentPairDiff;
                    }
                }
            }

            if (maxPairDiff == 0)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxPairDiff}");
            }
        }
    }
}
