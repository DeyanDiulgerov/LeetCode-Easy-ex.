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
            if (k == 1)
                return nums.Max();

            double max = 0;
            double newMax = 0;
            int left = 0, right = k - 1;

            for (int i = 0; i < k; i++)
                newMax += nums[i];

            var tempMax = newMax;
            newMax = (double)newMax / (double)k;
            max = Math.Max(max, newMax);

            while (left <= right && right < nums.Length - 1)
            {
                newMax = tempMax;
                newMax -= nums[left];
                left++;
                right++;
                newMax += nums[right];
                tempMax = newMax;
                newMax = (double)newMax / (double)k;
                max = Math.Max(max, newMax);
                if (max == 0)
                    max = newMax;
            }
            if (max != 0)
                return max;
            else
                return (double)nums.Sum() / (double)nums.Length;
        }
    }
}
