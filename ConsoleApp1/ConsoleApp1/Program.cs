using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            string x = "Qarabag";
            Console.WriteLine(Sqrt(a));
            Console.WriteLine(Sqrt(a,b));
            Print(x);
            Console.WriteLine(Sum(out a, b));
            Console.WriteLine(Sum(ref a, ref b));
        }
        static int Sqrt (int a)
        {
            return a * a;
        }
        static int Sqrt (int a, int b)
        {
            int c = a + b;
            return c*c;
        }
        static void Print (string x)
        {
            Console.WriteLine(x);
        }
        static int Sum (out int a, int b)
        {
            a= 0;
            a = a + b;
            return a;
        }
        static int Sum (ref int a, ref int b)
        {
            return  a + b;
        }
    }
}
