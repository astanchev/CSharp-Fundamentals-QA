using System;

namespace _35._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int i = 1; counter <= n; i++)
            {
                int br = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (br>0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(counter++);
                    br++;
                    if (counter > n)
                    {
                        return; ;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
