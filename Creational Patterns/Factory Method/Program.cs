using System;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Point.NewPolarPoint(2,3);
            Point.NewCartesianPoint(2,3);
        }
    }
}
