using System;

namespace LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            var rc = new Rectangle(2, 3);
            UseIt(rc);
            var sq = new Square(5);
            UseIt(sq);
        }

        public static void UseIt(Rectangle r)
        {
            r.Height = 10;
            Console.WriteLine($"Expected area of {10 * r.Width}, got {r.Area}");
        }
    }
}
