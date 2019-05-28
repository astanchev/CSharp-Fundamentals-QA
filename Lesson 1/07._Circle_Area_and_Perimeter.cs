using System;

namespace _07._Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double area = 1.0 * radius * radius * Math.PI;
            double perimeter = 2.0 * radius * Math.PI;
            Console.WriteLine($"{area:f4}");
            Console.WriteLine($"{perimeter:f4}");
        }
    }
}
