using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfDaysBetweenTwoDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // !!!DateTime.Parse()!!! -- !!!DateTime.Parse()!!! -- !!!DateTime.Parse()!!!
            Console.WriteLine(NumberOfDaysBetweenTwoDates("2019-06-29", "2019-06-30"));
            Console.WriteLine(NumberOfDaysBetweenTwoDates("2020-01-15", "2019-12-31"));
        }

        public static int NumberOfDaysBetweenTwoDates(string date1, string date2)
        {
            // !!!DateTime.Parse()!!! -- !!!DateTime.Parse()!!! -- !!!DateTime.Parse()!!!
            return Math.Abs((DateTime.Parse(date1) - DateTime.Parse(date2)).Days);
        }
    }
}
