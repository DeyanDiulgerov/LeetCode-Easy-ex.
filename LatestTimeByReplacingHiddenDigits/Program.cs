using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatestTimeByReplacingHiddenDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LatestTimeByReplacingHiddenDigits("?4:03"));
            Console.WriteLine(LatestTimeByReplacingHiddenDigits("??:3?"));
            Console.WriteLine(LatestTimeByReplacingHiddenDigits("2?:?0"));
            Console.WriteLine(LatestTimeByReplacingHiddenDigits("0?:3?"));
            Console.WriteLine(LatestTimeByReplacingHiddenDigits("1?:22"));
        }
        public static string LatestTimeByReplacingHiddenDigits(string time)
        {
            if (time[0] == '?' && (time[1] - 48 <= 3 || time[1] == '?'))
            {
                time = time.Remove(0, 1);
                time = time.Insert(0, "2");
            }
            if (time[0] == '?' && time[1] - 48 > 3)
            {
                time = time.Remove(0, 1);
                time = time.Insert(0, "1");
            }
            if (time[1] == '?' && time[0] == '2')
            {
                time = time.Remove(1, 1);
                time = time.Insert(1, "3");
            }
            if (time[1] == '?' && time[0] == '1' || time[0] == '0' && time[1] == '?')
            {
                time = time.Remove(1, 1);
                time = time.Insert(1, "9");
            }
            if (time[3] == '?')
            {
                time = time.Remove(3, 1);
                time = time.Insert(3, "5");
            }
            if (time[4] == '?')
            {
                time = time.Remove(4, 1);
                time = time.Insert(4, "9");
            }

            return time;
        }
    }
}
