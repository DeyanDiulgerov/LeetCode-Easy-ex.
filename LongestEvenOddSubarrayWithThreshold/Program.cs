using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestEvenOddSubarrayWithThreshold
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestEvenOddSubarrayWithThreshold(new int[] { 10, 1, 10 }, 3));
            Console.WriteLine(LongestEvenOddSubarrayWithThreshold(new int[] { 4 }, 1));
            Console.WriteLine(LongestEvenOddSubarrayWithThreshold(new int[] { 2 }, 2));
            Console.WriteLine(LongestEvenOddSubarrayWithThreshold(new int[] { 3, 2, 5, 4 }, 5));
            Console.WriteLine(LongestEvenOddSubarrayWithThreshold(new int[] { 1, 2 }, 2));
            Console.WriteLine(LongestEvenOddSubarrayWithThreshold(new int[] { 2, 3, 4, 5 }, 4));
        }
        public static int LongestEvenOddSubarrayWithThreshold(int[] nums, int threshold)
        {
            int left = 0, right = 0;
            int max = 0;

            while (left < nums.Length)
            {
                var listed = new List<int>();
                while (left < nums.Length && (nums[left] % 2 != 0))
                    left++;
                if (left == nums.Length)
                    break;

                listed.Add(nums[left]);
                right = left + 1;
                while (right < nums.Length)
                {
                    listed.Add(nums[right]);
                    right++;
                }
                bool validList = CheckIfListIsValid(listed, threshold);

                //Console.WriteLine(String.Join(",", listed));
                if (validList)
                    max = Math.Max(max, listed.Count());
                else
                {
                    while (!validList || listed.Count() > 0)
                    {
                        listed.RemoveAt(listed.Count() - 1);
                        //Console.WriteLine(String.Join(",", listed));
                        validList = CheckIfListIsValid(listed, threshold);
                        if (validList)
                            max = Math.Max(max, listed.Count());
                    }
                }
                left++;
            }

            return max;
        }

        public static bool CheckIfListIsValid(List<int> listed, int threshold)
        {
            for (int i = 0; i < listed.Count(); i++)
            {
                if (i == listed.Count() - 1)
                {
                    if (listed[i] > threshold)
                    {
                        return false;
                    }
                }
                else
                {
                    if (listed[i] > threshold)
                        return false;
                    if (listed[i] % 2 == listed[i + 1] % 2)
                        return false;
                }
            }
            return true;
        }
    }
}
