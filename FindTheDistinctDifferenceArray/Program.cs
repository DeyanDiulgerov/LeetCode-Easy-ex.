using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheDistinctDifferenceArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FindTheDistinctDifferenceArray(new int[] { 1, 2, 3, 4, 5 })));
            Console.WriteLine(String.Join(",", FindTheDistinctDifferenceArray(new int[] { 3, 2, 3, 4, 2 })));
        }

        public static int[] FindTheDistinctDifferenceArray(int[] nums)
        {
            int n = nums.Length;
            var result = new int[n];

            for (int i = 0; i < nums.Length; i++)
            {
                int suffixCount = 0;
                var listOfSuffixes = new List<int>();
                int prefixCount = 0;
                var listOfPrefixes = new List<int>();

                for (int s = i + 1; s < nums.Length; s++)
                {
                    if (!listOfSuffixes.Contains(nums[s]))
                    {
                        suffixCount++;
                        listOfSuffixes.Add(nums[s]);
                    }
                }

                for (int p = i; p >= 0; p--)
                {
                    if (!listOfPrefixes.Contains(nums[p]))
                    {
                        prefixCount++;
                        listOfPrefixes.Add(nums[p]);
                    }
                }

                result[i] = prefixCount - suffixCount;
            }

            return result;
        }
    }
}
