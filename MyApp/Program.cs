using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserAskAboutLeapYear();
        }

        public static bool IsLeapYear(int year)
        {
            return (year % 100 != 0) && (year % 4 == 0) || (year % 400 == 0);
        }

        public static void UserAskAboutLeapYear()
        {
            Console.WriteLine("Is it a leap year? Find out!");
            Console.Write("Please enter a year: ");

            var yearStr = Console.ReadLine();
            var year = int.Parse(yearStr);

            Console.WriteLine(IsLeapYear(year) ? "yay" : "nay");
        }
    }
}
