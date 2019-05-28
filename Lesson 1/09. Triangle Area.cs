using System;

namespace _09._Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = a * h / 2.0;

            Console.WriteLine($"{Math.Round(area, 2)}");
        }
    }
}
