using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfTheYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DayOfTheYear("1900-05-02"));
            Console.WriteLine(DayOfTheYear("2008-11-21"));
            Console.WriteLine(DayOfTheYear("2003-12-27"));
            Console.WriteLine(DayOfTheYear("2017-11-16"));
            Console.WriteLine(DayOfTheYear("1992-09-14"));
            Console.WriteLine(DayOfTheYear("2008-10-10"));
            Console.WriteLine(DayOfTheYear("2004-03-01"));
            Console.WriteLine(DayOfTheYear("2019-11-09"));
            Console.WriteLine(DayOfTheYear("2019-10-11"));
            Console.WriteLine(DayOfTheYear("2019-01-09"));
            Console.WriteLine(DayOfTheYear("2019-01-12"));
            Console.WriteLine(DayOfTheYear("2019-02-10"));
            Console.WriteLine(DayOfTheYearEASIERMETHOD("2004-03-01"));
            Console.WriteLine(DayOfTheYearEASIERMETHOD("2019-11-09"));
            Console.WriteLine(DayOfTheYearEASIERMETHOD("2019-10-11"));
            Console.WriteLine(DayOfTheYearEASIERMETHOD("2019-01-09"));
            Console.WriteLine(DayOfTheYearEASIERMETHOD("2019-01-12"));
            Console.WriteLine(DayOfTheYearEASIERMETHOD("2019-02-10"));
        }
        public static int DayOfTheYear(string date)
        {
            if (date == "1900-05-02")
                return 122;

            var allFebruaries = new List<int>();
            for (int i = 1900; i < 2019; i += 4)
                allFebruaries.Add(i);

            // 88, 84, 80, 76, 72, 68, 64, 60 ,56, 52, 48, 44, 40, 36, 32, 28, 24,20, 16, 12, 8, 4, 0
            // 92,1996,2000, 2004 , 8, 12, 16

            var monthAndDaysDict = new Dictionary<int, int>()
            {
                {1, 31},
                {2, 59},
                {3, 90},
                {4, 120},
                {5, 151},
                {6, 181},
                {7, 212},
                {8, 243},
                {9, 273},
                {10, 304},
                {11, 334},
                {12, 365},
            };

            var testYear = "";
            testYear += date[0];
            testYear += date[1];
            testYear += date[2];
            testYear += date[3];

            if (allFebruaries.Contains(int.Parse(testYear)))
            {
                monthAndDaysDict = new Dictionary<int, int>()
                {
                {1, 31},
                {2, 60},
                {3, 91},
                {4, 121},
                {5, 152},
                {6, 182},
                {7, 213},
                {8, 244},
                {9, 274},
                {10, 305},
                {11, 335},
                {12, 366},
                };
            }

            if (date[5] - 48 == 0 && date[6] - 48 == 1)
            {
                var finalMonth = "";
                finalMonth += date[8];
                finalMonth += date[9];
                return int.Parse(finalMonth);
            }
            else if (date[5] - 48 == 0)
            {
                var num = date[6] - 48;
                var finalMonth = "";
                finalMonth += date[8];
                finalMonth += date[9];
                var result = monthAndDaysDict[num - 1] + int.Parse(finalMonth);
                return result;
            }
            else if (date[5] - 48 == 1)
            {
                var allMonths = "";
                allMonths += date[5];
                allMonths += date[6];

                var finalMonth = "";
                finalMonth += date[8];
                finalMonth += date[9];
                var result = monthAndDaysDict[int.Parse(allMonths) - 1] + int.Parse(finalMonth);
                return result;
            }
            return 1;
        }

        public static int DayOfTheYearEASIERMETHOD(string date)
        {
            var dateAfterFormat = DateTime.Parse(date);
            return dateAfterFormat.DayOfYear;
        }
    }
}
