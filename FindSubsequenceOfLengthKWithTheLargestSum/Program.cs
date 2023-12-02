using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSubsequenceOfLengthKWithTheLargestSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",",
                FindSubsequenceOfLengthKWithTheLargestSum(new int[] { 2, 1, 3, 3 }, 2)));
            Console.WriteLine(String.Join(",", 
                FindSubsequenceOfLengthKWithTheLargestSum(new int[] { -1, -2, 3, 4 }, 3)));
            Console.WriteLine(String.Join(",", 
                FindSubsequenceOfLengthKWithTheLargestSum(new int[] { 3, 4, 3, 3 }, 2)));
        }
        public static int[] FindSubsequenceOfLengthKWithTheLargestSum(int[] nums, int k)
        {
            var listed = new List<int>(nums);
            listed.Sort();
            var biggestSumList = new List<int>();
            var resultList = new List<int>();
            int n = nums.Length;

            for (int i = n - 1; i >= n - k; i--)
                biggestSumList.Add(listed[i]);

            for (int i = 0; i < nums.Length; i++)
            {
                if (biggestSumList.Contains(nums[i])
                 && biggestSumList.Count(x => x == nums[i]) > resultList.Count(x => x == nums[i]))
                    resultList.Add(nums[i]);

                if (resultList.Count() == k)
                    break;
            }
            return resultList.ToArray();
        }
    }
}
