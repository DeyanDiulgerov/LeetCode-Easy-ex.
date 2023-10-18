using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetermineIfTwoEventsHaveConflict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DetermineIfTwoEventsHaveConflict(
                new string[] { "01:15", "02:00" }, new string[] { "02:00", "03:00" }));
            Console.WriteLine(DetermineIfTwoEventsHaveConflict(
                new string[] { "01:00", "02:00" }, new string[] { "01:20", "03:00" }));
            Console.WriteLine(DetermineIfTwoEventsHaveConflict(
                new string[] { "10:00", "11:00" }, new string[] { "14:00", "15:00" }));
        }

        public static bool DetermineIfTwoEventsHaveConflict(string[] event1, string[] event2)
        {
            var start1 = ConvertTimeToNum(event1[0]);
            var start2 = ConvertTimeToNum(event2[0]);
            var end1 = ConvertTimeToNum(event1[1]);
            var end2 = ConvertTimeToNum(event2[1]);

            for (int i = start1; i <= end1; i++)
            {
                if (i == start2 || i == end2)
                    return true;
            }
            for (int i = start2; i <= end2; i++)
            {
                if (i == start1 || i == end1)
                    return true;
            }

            return false;

            int ConvertTimeToNum(string eventt)
            {
                var text = "";

                for (int i = 0; i < eventt.Length; i++)
                {
                    if (char.IsDigit(eventt[i]))
                        text += eventt[i];
                }

                return int.Parse(text);
            }
        }

        public static int ConvertTimeToNum(string eventt)
        {
            var text = "";

            for (int i = 0; i < eventt.Length; i++)
            {
                if (char.IsDigit(eventt[i]))
                    text += eventt[i];
            }

            return int.Parse(text);
        }
    }
}
