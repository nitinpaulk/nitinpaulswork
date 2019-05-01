using System;

namespace LearningDesignPatterns
{
   public class Point
    {
        // factory method
        private double x, y;

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{nameof(x)} : {x}, {nameof(y)} : {y}";
        }

        public static class Factory
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
    }

    class FactoryMethod
    {
        static void Main(string[] args)
        {
            //var point = Point.NewPolarPoint(10, 20);
            //Console.WriteLine("Polar point is {0}", point.ToString());

            //var cartpoint = Point.NewCartesianPoint(10, 20);
            //Console.WriteLine("Cartesian point is {0}", cartpoint.ToString());

            var point = Point.Factory.NewPolarPoint(10, 20);
            Console.WriteLine("Polar point is {0}", point.ToString());

            var cartpoint = Point.Factory.NewCartesianPoint(10, 20);
            Console.WriteLine("Cartesian point is {0}", cartpoint.ToString());

            Console.ReadLine();
        }

        public int Method1(int a, int b)
        {
            return 1;
        }

        public string Method1(int a, int b)
        {
            return string.Empty;
        }

        public string Method1(int a, string b)
        {
            return string.Empty;
        }
    }
}
