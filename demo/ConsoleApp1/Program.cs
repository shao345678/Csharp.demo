using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FTI(30));
        }
        static int FTI(int feet)
        {
            int inches = feet * 12;
            return inches;
        }
    }
}
