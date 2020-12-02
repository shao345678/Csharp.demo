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
            Console.WriteLine(1.GetType());
            int m = int.MaxValue;m++;
            Console.WriteLine(1.0/3+ 1.0 / 3 + 1.0 / 3 ==1);
            
        }
        void foo(int x, int y) { }
        void test()
        {
            foo(1, 1);
        }
        public struct Point
        {
            public int x;
            public int y;
        }

    }
}
