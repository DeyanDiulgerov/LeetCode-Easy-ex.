using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOddNumbersInAnIntervalRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountOddNumbersInAnIntervalRange(3, 7));
            Console.WriteLine(CountOddNumbersInAnIntervalRange(9, 10));
        }
        public static int CountOddNumbersInAnIntervalRange(int low, int high)
        {
            int count = 0;
            for (long i = low; i <= high; i++)
            {
                if (i % 2 != 0)
                    count++;
            }
            return count;
        }
    }
}
