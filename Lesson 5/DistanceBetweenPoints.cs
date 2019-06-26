using System;

namespace _15._Distance_Between_Points
{
    class DistanceBetweenPoints
    {
        public class Point
        {
            public double XValue { get; set; }
            public double YValue { get; set; }

            public Point(double xValue, double yValue)
            {
                XValue = xValue;
                YValue = yValue;
            }
        }
        static void Main(string[] args)
        {
            string[] inputPointA = Console.ReadLine().Split();
            string[] inputPointB = Console.ReadLine().Split();

            double x1 = double.Parse(inputPointA[0]);
            double y1 = double.Parse(inputPointA[1]);

            double x2 = double.Parse(inputPointB[0]);
            double y2 = double.Parse(inputPointB[1]);

            Point pointA = new Point(x1, y1);
            Point pointB = new Point(x2, y2);

            double distance = FindDistance(pointA, pointB);

            Console.WriteLine($"{distance:F3}");
        }

        private static double FindDistance(Point pointA, Point pointB)
        {
            double result = 0.0;
            result = Math.Sqrt(Math.Pow(pointA.XValue - pointB.XValue, 2) +
                               Math.Pow(pointA.YValue - pointB.YValue, 2));
            return result;
        }
    }
}
