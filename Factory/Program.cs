using System;
using System.Threading.Tasks;
using static System.Console;

namespace Factory
{
    

    public class Point
    {
        // factory method

        private readonly double x;
        private readonly double y;

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
        }

        public static Point Origin = new Point(0, 0);

        public static class FactoryPattern
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

    public class Program
    {
        static void Main(string[] args)
        {
            var point = Point.FactoryPattern.NewPolarPoint(1.0, Math.PI / 2);
            WriteLine(point);

            var origin = Point.Origin;
        }
    }
}
