using System;
using static System.Console;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static public int Area(Rectangle r) => r.Width * r.Heigth;
        static void Main(string[] args)
        {
            var rc = new Rectangle(2, 3);
            WriteLine($"{rc} has area {Area(rc)}");

            Rectangle sq = new Square
            {
                Width = 4
            };
            WriteLine($"{sq} has area {Area(sq)}");
        }
    }
}
