using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumAverageSubarrayI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumAverageSubarrayI(new int[] { 0, 4, 0, 3, 2 }, 1));
            Console.WriteLine(MaximumAverageSubarrayI(new int[] { 6, 8, 6, 8, 0, 4, 1, 2, 9, 9 }, 2));
            Console.WriteLine(MaximumAverageSubarrayI(new int[] { -1 }, 1));
            Console.WriteLine(MaximumAverageSubarrayI(new int[] { 1, 12, -5, -6, 50, 3 }, 4));
            Console.WriteLine(MaximumAverageSubarrayI(new int[] { 5 }, 1));
        }

        public static double MaximumAverageSubarrayI(int[] nums, int k)
        {
            double sum = nums.Take(k).Sum();
            double max = sum / k;
            int left = 0, right = k;
            while(right < nums.Length)
            {
                sum -= nums[left];
                sum += nums[right];
                left++;
                right++;
                max = Math.Max(max, sum / k);
            }
            return max;
        }
    }
}
