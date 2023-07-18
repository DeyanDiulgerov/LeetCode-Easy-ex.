using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubsequenceWithLimitedSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", LongestSubsequenceWithLimitedSum
                (new int[] { 4, 5, 2, 1 }, new int[] { 3, 10, 21 })));

            Console.WriteLine(String.Join(",", LongestSubsequenceWithLimitedSum
                (new int[] { 2, 3, 4, 5 }, new int[] { 1 })));
        }

        public static int[] LongestSubsequenceWithLimitedSum(int[] nums, int[] queries)
        {
            int n = nums.Length;
            int m = queries.Length;
            int[] answer = new int[m];

            for (int i = 0; i < m; i++)
            {
                if (nums.Sum() <= queries[i])
                    answer[i] = n;
                else
                {
                    var listedNums = new List<int>(nums);
                    listedNums.Sort();
                    Array.Sort(nums);

                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (listedNums.Count() == 0)
                            break;
                        else if (queries[i] <= 0 || queries[i] < nums[j])
                            break;

                        queries[i] -= nums[j];
                        listedNums.Remove(nums[j]);

                        answer[i]++;
                    }
                }
            }

            return answer;
        }
    }
}
