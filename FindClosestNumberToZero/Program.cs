using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindClosestNumberToZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindClosestNumberToZero(new int[] { -100000, -100000 }));
            Console.WriteLine(FindClosestNumberToZero(new int[] { 0 }));
            Console.WriteLine(FindClosestNumberToZero(new int[] { -4, -2, 1, 4, 8 }));
            Console.WriteLine(FindClosestNumberToZero(new int[] { 2, -1, 1 }));
        }
        public static int FindClosestNumberToZero(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            else if (nums.Contains(0))
                return 0;

            var positiveCount = 1;
            while (!nums.Contains(positiveCount) && positiveCount < 100000)
            {
                positiveCount++;
            }

            var negativeCount = -1;
            while (!nums.Contains(negativeCount) && negativeCount > -100000)
            {
                negativeCount--;
                if (-negativeCount >= positiveCount && nums.Contains(positiveCount))
                    return positiveCount;
            }

            if (-negativeCount >= positiveCount && nums.Contains(positiveCount))
                return positiveCount;
            else
                return negativeCount;
        }
    }
}
