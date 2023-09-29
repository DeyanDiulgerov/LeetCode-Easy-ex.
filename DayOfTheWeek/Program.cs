using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DayOfTheWeek(31, 8, 2019));
            Console.WriteLine(DayOfTheWeek(18, 7, 1999));
            Console.WriteLine(DayOfTheWeek(15, 8, 1993));
        }

        public static string DayOfTheWeek(int day, int month, int year)
        {
            return new DateTime(year, month, day).ToString("dddd");
        }
    }
}
