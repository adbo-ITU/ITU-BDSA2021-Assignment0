using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool IsLeapYear(int year)
        {
            return (year % 100 != 0) && (year % 4 == 0) || (year % 400 == 0);
        }
    }
}
