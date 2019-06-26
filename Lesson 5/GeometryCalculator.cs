using System;

namespace _11._Geometry_Calculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            double result = CalculateArea(figure);

            Console.WriteLine($"{result:f2}");

        }

        private static double CalculateArea(string figure)
        {
            double area = 0.0;
            switch (figure)
            {
                case "triangle":
                {
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());

                    area = side * height / 2.0;
                }
                    break;
                case "square":
                {
                    double side = double.Parse(Console.ReadLine());

                    area = side * side;
                }
                    break;
                case "rectangle":
                {
                    double width = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());

                    area = width * height;
                }
                    break;
                case "circle":
                {
                    double radius = double.Parse(Console.ReadLine());
                    
                    area = radius * radius * Math.PI;
                }
                    break;

                default: break;
            }

            return area;
        }
    }
}
