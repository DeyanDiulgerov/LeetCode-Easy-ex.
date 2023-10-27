using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSumOfMountainTripletsI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumSumOfMountainTripletsI(new int[] { 49, 50, 48 }));
            Console.WriteLine(MinimumSumOfMountainTripletsI(new int[] { 8, 6, 1, 5, 3 }));
            Console.WriteLine(MinimumSumOfMountainTripletsI(new int[] { 5, 4, 8, 7, 10, 2 }));
            Console.WriteLine(MinimumSumOfMountainTripletsI(new int[] { 6, 5, 4, 3, 4, 5 }));
        }
        public static int MinimumSumOfMountainTripletsI(int[] nums)
        {
            var min = 1000;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] < nums[j] && nums[k] < nums[j])
                        {
                            var sum = nums[i] + nums[j] + nums[k];
                            min = Math.Min(min, sum);
                        }
                    }
                }
            }
            if (min == 1000)
                return -1;
            else
                return min;
        }
    }
}
