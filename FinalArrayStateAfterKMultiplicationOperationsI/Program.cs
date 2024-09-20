using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalArrayStateAfterKMultiplicationOperationsI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FinalArrayStateAfterKMultiplicationOperationsI(new int[] { 2, 1, 3, 5, 6 }, 5, 2)));
            Console.WriteLine(String.Join(",", FinalArrayStateAfterKMultiplicationOperationsI(new int[] { 1, 2 }, 3, 4)));
        }

        public static int[] FinalArrayStateAfterKMultiplicationOperationsI(int[] nums, int k, int multiplier)
        {
            for (int i = 0; i < k; i++)
            {
                int min = nums.Min();
                int index = Array.IndexOf(nums, min);
                nums[index] = min * multiplier;
            }
            return nums;
        }
    }
}
