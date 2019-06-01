using System;

namespace _11._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0.0;

            switch (figure)
            {
                case "square":
                    {
                        double side = double.Parse(Console.ReadLine());
                        area = side * side;
                    }
                    break;
                case "rectangle":
                    {
                        double sideA = double.Parse(Console.ReadLine());
                        double sideB = double.Parse(Console.ReadLine());
                        area = sideA * sideB;
                    }
                    break;
                case "circle":
                    {
                        double radius = double.Parse(Console.ReadLine());
                        area = radius * radius * Math.PI;
                    }
                    break;
                case "triangle":
                    {
                        double side = double.Parse(Console.ReadLine());
                        double high = double.Parse(Console.ReadLine());
                        area = side * high / 2;
                    }
                    break;
            }

            Console.WriteLine($"{Math.Round(area, 3)}");
        }
    }
}
