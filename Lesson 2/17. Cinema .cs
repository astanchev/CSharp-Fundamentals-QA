using System;

namespace _17._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            double price = 0.0;

            int seats = rows * cols;

            switch (type)
            {
                case "Premiere": price = 12.0; break;
                case "Normal": price = 7.5; break;
                case "Discount": price = 5.0; break;
            }

            Console.WriteLine($"{price*seats:f2}");
        }
    }
}
