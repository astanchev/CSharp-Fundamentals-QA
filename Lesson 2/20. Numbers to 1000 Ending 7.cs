using System;

namespace _20._Numbers_to_1000_Ending_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int br = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 10 == 7)
                {
                    if (br > 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(i);
                    br++;
                }
            }
        }
    }
}
