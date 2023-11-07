using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumNumberOfOperationsToConvertTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumNumberOfOperationsToConvertTime("09:41", "10:34"));
            Console.WriteLine(MinimumNumberOfOperationsToConvertTime("02:30", "04:35"));
            Console.WriteLine(MinimumNumberOfOperationsToConvertTime("11:00", "11:01"));

        }
        public static int MinimumNumberOfOperationsToConvertTime(string current, string correct)
        {
            int counter = 0;
            var arrCurr = "";
            var arrCorr = "";
            var first = 0;
            var second = 0;
            arrCurr += current[0] - 48;
            arrCurr += current[1] - 48;
            first = int.Parse(arrCurr) * 60;
            arrCurr = (current[3] - 48).ToString();
            arrCurr += current[4] - 48;
            first += int.Parse(arrCurr);
            Console.WriteLine(first);
            arrCorr += correct[0] - 48;
            arrCorr += correct[1] - 48;
            second = int.Parse(arrCorr) * 60;
            arrCorr = (correct[3] - 48).ToString();
            arrCorr += correct[4] - 48;
            second += int.Parse(arrCorr);
            Console.WriteLine(second);

            var diff = second - first;

            while (diff > 0)
            {
                if (diff >= 60)
                    diff -= 60;
                else if (diff >= 15)
                    diff -= 15;
                else if (diff >= 5)
                    diff -= 5;
                else
                    diff -= 1;

                counter++;
            }

            return counter;
        }
    }
}
