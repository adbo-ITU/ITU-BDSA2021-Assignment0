using System;

namespace MyApp
{
    public class Program
    {
        public static int minYear = 1582;

        static void Main(string[] args)
        {
            UserAskAboutLeapYear();
        }

        public static bool IsLeapYear(int year)
        {
            if (year < minYear)
            {
                throw new NotSupportedException($"Received year {year} but only supports year {minYear} and forth");
            }

            return (year % 100 != 0) && (year % 4 == 0) || (year % 400 == 0);
        }

        public static void UserAskAboutLeapYear()
        {
            Console.WriteLine("Is it a leap year? Find out!");
            Console.Write("Please enter a year: ");

            var yearStr = Console.ReadLine();

            try
            {
                var year = int.Parse(yearStr);
                Console.WriteLine(IsLeapYear(year) ? "yay" : "nay");
            }
            catch (FormatException)
            {
                Console.WriteLine("The year must be an integer - please try again.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine($"The year must be above {minYear} - please try again.");
            }
        }
    }
}
