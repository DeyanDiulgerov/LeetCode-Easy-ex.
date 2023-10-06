using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumberAtLeastTwiceOfOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestNumberAtLeastTwiceOfOthers(new int[] { 3, 6, 1, 0 }));
            Console.WriteLine(LargestNumberAtLeastTwiceOfOthers(new int[] { 1, 2, 3, 4 }));
        }
        public static int LargestNumberAtLeastTwiceOfOthers(int[] nums)
        {
            int target = 0;

            for (int i = 0; i < nums.Length; i++)
                target = Math.Max(target, nums[i]);

            var index = Array.IndexOf(nums, target);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != target && target < nums[i] * 2)
                    return -1;
            }
            return index;
        }
    }
}
