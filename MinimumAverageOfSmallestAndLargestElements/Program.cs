using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumAverageOfSmallestAndLargestElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumAverageOfSmallestAndLargestElements(new int[] { 7, 8, 3, 4, 15, 13, 4, 1 }));
            Console.WriteLine(MinimumAverageOfSmallestAndLargestElements(new int[] { 1, 9, 8, 3, 10, 5 }));
            Console.WriteLine(MinimumAverageOfSmallestAndLargestElements(new int[] { 1, 2, 3, 7, 8, 9 }));
        }
        public static double MinimumAverageOfSmallestAndLargestElements(int[] nums)
        {
            Array.Sort(nums);
            double min = int.MaxValue;
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                double newMin = (double)(nums[left] + nums[right]) / 2;
                min = Math.Min(min, newMin);
                left++;
                right--;
            }
            return min;
        }
    }
}
