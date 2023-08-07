using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumAscendingSubarraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumAscendingSubarraySum(new int[] { 3, 6, 10, 1, 8, 9, 9, 8, 9 }));
            Console.WriteLine(MaximumAscendingSubarraySum(new int[] { 10, 20, 30, 5, 10, 50 }));
            Console.WriteLine(MaximumAscendingSubarraySum(new int[] { 10, 20, 30, 40, 50 }));
            Console.WriteLine(MaximumAscendingSubarraySum(new int[] { 12, 17, 15, 13, 10, 11, 12 }));
        }

        public static int MaximumAscendingSubarraySum(int[] nums)
        {
            var currSum = nums[0];
            var maxSum = nums[0];
            var allSums = new List<int>();

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= nums[i - 1])
                {
                    allSums.Add(maxSum);
                    maxSum = 0;
                    currSum = 0;
                }

                currSum = Math.Max(nums[i], nums[i] + currSum);
                maxSum = Math.Max(maxSum, currSum);
            }

            allSums.Add(maxSum);
            allSums.Sort();
            var test = allSums.Last();

            return test;
        }
    }
}
