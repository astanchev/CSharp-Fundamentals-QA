using System;

namespace _11._Real_Number_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(b, a));
        }
    }
}
