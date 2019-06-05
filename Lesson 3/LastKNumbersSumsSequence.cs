using System;

namespace _07._Last_K_Numbers_Sums_Sequence
{
    class LastKNumbersSumsSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] arr = new long[n];
            arr[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long currentSum = 0;
                int startIndex = -1;
                if (i - k <= 0)
                {
                    startIndex = 0;
                }
                else
                {
                    startIndex = i - k;
                }

                for (int j = startIndex; j < i; j++)
                {
                    currentSum += arr[j];
                }

                arr[i] = currentSum;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
