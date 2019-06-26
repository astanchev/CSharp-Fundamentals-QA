using System;

namespace _18._Intersection_of_Circles
{
    class IntersectionofCircles
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

        public class Circle
        {
            public Point Center { get; set; }
            public double Radius { get; set; }

            public Circle(Point center, double radius)
            {
                Center = center;
                Radius = radius;
            }
        }

        static void Main(string[] args)
        {
            string[] inputPointA = Console.ReadLine().Split();
            string[] inputPointB = Console.ReadLine().Split();

            double xA = double.Parse(inputPointA[0]);
            double yA = double.Parse(inputPointA[1]);
            double radiusA = double.Parse(inputPointA[2]);
            Point centerA = new Point(xA, yA);
            Circle circleA = new Circle(centerA, radiusA);

            double xB = double.Parse(inputPointB[0]);
            double yB = double.Parse(inputPointB[1]);
            double radiusB = double.Parse(inputPointB[2]);
            Point centerB = new Point(xB, yB);
            Circle circleB = new Circle(centerB, radiusB);

            if (Intersect(circleA, circleB))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static bool Intersect(Circle circleA, Circle circleB)
        {
            bool isIntersect = false;
            double distance = FindDistance(circleA.Center, circleB.Center);

            if (distance <= circleA.Radius + circleB.Radius)
            {
                isIntersect = true;
            }

            return isIntersect;
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
