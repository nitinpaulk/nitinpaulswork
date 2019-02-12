using System;

namespace LearningDesignPatterns
{
    /// <summary>
    /// Learning the Factory method pattern
    /// </summary>
    public static class PointFactory
    {
        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }
    }

    public class Point
    {
        // factory method
        private double x, y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{nameof(x)} : {x}, {nameof(y)} : {y}";
        }
    }

    class FactoryMethod
    {
        static void Main(string[] args)
        {
            //var point = Point.NewPolarPoint(10, 20);
            //Console.WriteLine("Polar point is {0}", point.ToString());

            //var cartpoint = Point.NewCartesianPoint(10, 20);
            //Console.WriteLine("Cartesian point is {0}", cartpoint.ToString());

            var point = PointFactory.NewPolarPoint(10, 20);
            Console.WriteLine("Polar point is {0}", point.ToString());

            var cartpoint = PointFactory.NewCartesianPoint(10, 20);
            Console.WriteLine("Cartesian point is {0}", cartpoint.ToString());

            Console.ReadLine();
        }
    }
}
