using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfValidClockTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfValidClockTimes("?4:22"));
            Console.WriteLine(NumberOfValidClockTimes("??:2?"));
            Console.WriteLine(NumberOfValidClockTimes("2?:??"));
            Console.WriteLine(NumberOfValidClockTimes("?5:00"));
            Console.WriteLine(NumberOfValidClockTimes("0?:0?"));
            Console.WriteLine(NumberOfValidClockTimes("??:??"));
        }

        public static int NumberOfValidClockTimes(string time)
        {
            var resultCount = 1;

            if (time[0] == '?' && time[1] == '?')
                resultCount *= 24;
            else // check !separatly! time[0] And time[1]
            {
                if (time[0] == '?')
                {
                    if (time[1] - 48 <= 3)
                        resultCount *= 3;
                    else
                        resultCount *= 2;
                }
                if (time[1] == '?')
                {
                    if (time[0] - 48 == 2)
                        resultCount *= 4;
                    else
                        resultCount *= 10;
                }
            }
            if (time[3] == '?')
                resultCount *= 6;
            if (time[4] == '?')
                resultCount *= 10;

            return resultCount;
        }
    }
}
