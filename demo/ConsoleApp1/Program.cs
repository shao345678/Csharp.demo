using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            Point p2 = p1;
            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);
            p1.x = 9;
            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);

        }
        public struct Point
        {
            public int x;
            public int y;
        }

    }
}
