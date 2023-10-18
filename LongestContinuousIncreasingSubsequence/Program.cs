using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestContinuousIncreasingSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestContinuousIncreasingSubsequence(new int[] { 1, 3, 5, 7 }));
            Console.WriteLine(LongestContinuousIncreasingSubsequence(new int[] { 1, 3, 5, 4, 7 }));
            Console.WriteLine(LongestContinuousIncreasingSubsequence(new int[] { 2, 2, 2, 2, 2 }));
        }

        public static int LongestContinuousIncreasingSubsequence(int[] nums)
        {
            int max = 0;
            int counter = 1;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                    counter++;
                else
                {
                    max = Math.Max(max, counter);
                    counter = 1;
                }
            }
            max = Math.Max(max, counter);
            return max;
        }
    }
}
