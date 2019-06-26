using System;
using System.Collections.Generic;

namespace _17._Closest_Two_Points
{
    class ClosestTwoPoints
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
            int numberPoints = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();

            for (int i = 0; i < numberPoints; i++)
            {
                string[] inputPoint = Console.ReadLine().Split();
                double x = double.Parse(inputPoint[0]);
                double y = double.Parse(inputPoint[1]);

                Point currentPoint = new Point(x, y);

                points.Add(currentPoint);
            }

            Point[] closestPoints = new Point[2];

            closestPoints = FindClosestPoints(points);

            Console.WriteLine($"{FindDistance(closestPoints[0], closestPoints[1]):f3}");
            Console.WriteLine($"({closestPoints[0].XValue}, {closestPoints[0].YValue})");
            Console.WriteLine($"({closestPoints[1].XValue}, {closestPoints[1].YValue})");

        }

        private static Point[] FindClosestPoints(List<Point> points)
        {
            Point[] closestPoints = new Point[2];
            double closestDistance = double.MaxValue;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i+1; j < points.Count; j++)
                {
                    double currentDistance = FindDistance(points[i], points[j]);
                    if (currentDistance < closestDistance)
                    {
                        closestDistance = currentDistance;
                        closestPoints[0] = points[i];
                        closestPoints[1] = points[j];
                    }
                }
            }

            return closestPoints;
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
