using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestRangeI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SmallestRangeI(new int[] { 2, 7, 2 }, 1));
            Console.WriteLine(SmallestRangeI(new int[] { 1, 3, 6 }, 3));
            Console.WriteLine(SmallestRangeI(new int[] { 0, 10 }, 2));
            Console.WriteLine(SmallestRangeI(new int[] { 1 }, 0));
        }

        public static int SmallestRangeI(int[] nums, int k)
        {
            var max = nums.Max();
            var min = nums.Min();

            if (2 * k >= max - min)
            {
                return 0;
            }
            else
            {
                return max - min - 2 * k;
            }
        }
    }
}
