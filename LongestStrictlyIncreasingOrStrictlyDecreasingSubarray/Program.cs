using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestStrictlyIncreasingOrStrictlyDecreasingSubarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestStrictlyIncreasingOrStrictlyDecreasingSubarray(new int[] { 1, 4, 3, 3, 2 }));
            Console.WriteLine(LongestStrictlyIncreasingOrStrictlyDecreasingSubarray(new int[] { 3, 3, 3, 3 }));
            Console.WriteLine(LongestStrictlyIncreasingOrStrictlyDecreasingSubarray(new int[] { 3, 2, 1 }));
        }
        public static int LongestStrictlyIncreasingOrStrictlyDecreasingSubarray(int[] nums)
        {
            int max = 1;
            int count = 1;
            int left = 0, right = 1;
            while (right < nums.Length)
            {
                while (right < nums.Length && nums[left] < nums[right])
                {
                    left++;
                    right++;
                    count++;
                }
                max = Math.Max(max, count);
                if (right >= nums.Length)
                    break;
                left = right;
                right++;
                count = 1;
            }
            left = 0;
            right = 1;
            count = 1;
            while (right < nums.Length)
            {
                while (right < nums.Length && nums[left] > nums[right])
                {
                    left++;
                    right++;
                    count++;
                }
                max = Math.Max(max, count);
                if (right >= nums.Length)
                    break;
                left = right;
                right++;
                count = 1;
            }
            return max;
        }
    }
}
