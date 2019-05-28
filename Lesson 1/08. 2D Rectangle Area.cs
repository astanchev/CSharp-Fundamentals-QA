using System;

namespace _08._2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double sideA = Math.Abs(x1 - x2);
            double sideB = Math.Abs(y1 - y2);

            double area = 1.0 * sideA * sideB;
            double perimeter = 2.0 * sideA + 2.0 * sideB;

            Console.WriteLine($"{area}");
            Console.WriteLine($"{perimeter}");
        }
    }
}
