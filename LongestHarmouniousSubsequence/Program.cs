using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestHarmouniousSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestHarmouniousSubsequence(new int[] { 1, 4, 1, 3, 1, -14, 1, -13 }));
            Console.WriteLine(LongestHarmouniousSubsequence(new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17 }));
            Console.WriteLine(LongestHarmouniousSubsequence(new int[] { -3, -1, -1, -3, -1, -2 }));
            Console.WriteLine(LongestHarmouniousSubsequence(new int[] { -3, -1, -1, -1, -3, -2 }));
            Console.WriteLine(LongestHarmouniousSubsequence(new int[] { -3, -1, -3, -1, -1, -2 }));
            Console.WriteLine(LongestHarmouniousSubsequence(new int[] { 1, 3, 2, 2, 5, 2, 3, 7 }));
            Console.WriteLine(LongestHarmouniousSubsequence(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(LongestHarmouniousSubsequence(new int[] { 1, 1, 1, 1 }));
        }
        public static int LongestHarmouniousSubsequence(int[] nums)
        {
            if (nums.All(x => x == nums[0]))
                return 0;

            int left = 0, right = 0;
            int max = 0;
            int n = nums.Length;

            while (left < n - 1)
            {
                right = left + 1;
                var firstNum = nums[left];
                var minusSecond = nums[left] - 1;
                var plusSecond = nums[left] + 1;

                var permRight = right;

                var newMax = SearchTillEnd(firstNum, minusSecond, right);
                max = Math.Max(max, newMax);

                right = permRight;

                newMax = SearchTillEnd(firstNum, plusSecond, right);
                max = Math.Max(max, newMax);

                left++;
            }
            return max;

            int SearchTillEnd(int first, int secondNum, int rIndex)
            {
                var newList = new List<int>();
                newList.Add(first);

                while (rIndex < n)
                {
                    if (nums[rIndex] == first || nums[rIndex] == secondNum)
                        newList.Add(nums[rIndex]);

                    rIndex++;
                }

                if (newList.Count() != 0 && newList.Any(x => x != newList[0]))
                    max = Math.Max(max, newList.Count());

                return max;
            }
        }
    }
}
