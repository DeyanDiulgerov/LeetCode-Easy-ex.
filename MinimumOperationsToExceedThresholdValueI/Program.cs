using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumOperationsToExceedThresholdValueI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumOperationsToExceedThresholdValueI(new int[] { 2, 11, 10, 1, 3 }, 10));
            Console.WriteLine(MinimumOperationsToExceedThresholdValueI(new int[] { 1, 1, 2, 4, 9 }, 1));
            Console.WriteLine(MinimumOperationsToExceedThresholdValueI(new int[] { 1, 1, 2, 4, 9 }, 9));
        }
        public static int MinimumOperationsToExceedThresholdValueI(int[] nums, int k)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= k)
                    return i;
            }
            return 0;
        }
    }
}
