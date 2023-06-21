using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusyStudentDoingHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BusyStudentDoingHomework(new int[] { 1, 2, 3 }, new int[] { 3, 2, 7 }, 4));
            Console.WriteLine(BusyStudentDoingHomework(new int[] { 4 }, new int[] { 4 }, 4));
            Console.WriteLine(BusyStudentDoingHomework(new int[] { 1, 2, 3 }, new int[] { 3, 2, 7 }, 4));
        }

        public static int BusyStudentDoingHomework(int[] startTime, int[] endTime, int queryTime)
        {
            int counter = 0;

            for (int i = 0; i < startTime.Length; i++)
            {
                for (int j = startTime[i]; j <= endTime[i]; j++)
                {
                    if (j == queryTime)
                        counter++;
                }
            }

            return counter;
        }
    }
}
