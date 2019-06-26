using System;

namespace _04._Calculate_Triangle_Area
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetRectangleArea(side, height);
            Console.WriteLine($"{area}");
        }

        static double GetRectangleArea(double side, double height)
        {
            return side * height / 2;
        }
    }
}
