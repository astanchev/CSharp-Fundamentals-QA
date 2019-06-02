using System;

namespace _36._Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;

            for (int row = 0; row < n; row++)
            {
                int br = 0;
                for (int col = 0; col < n; col++)
                {
                    num = row + col + 1;
                    if (num > n)
                    {
                        num = 2 * n - num;
                    }

                    if (br > 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(num);
                    br++;
                }

                Console.WriteLine();
            }
        }
    }
}
