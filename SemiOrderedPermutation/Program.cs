using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemiOrderedPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SemiOrderedPermutation(new int[] { 2, 4, 1, 3 }));
            Console.WriteLine(SemiOrderedPermutation(new int[] { 2, 1, 4, 3 }));
            Console.WriteLine(SemiOrderedPermutation(new int[] { 1, 3, 4, 2, 5 }));
        }

        public static int SemiOrderedPermutation(int[] nums)
        {
            int n = nums.Length;
            int counter = 0;

            while (nums[0] != 1 || nums[nums.Length - 1] != n)
            {
                var oneIndex = Array.IndexOf(nums, 1);

                if (oneIndex != 0)
                {
                    var testOne = nums[oneIndex];
                    nums[oneIndex] = nums[oneIndex - 1];
                    nums[oneIndex - 1] = testOne;
                    counter++;
                }

                var indexN = Array.IndexOf(nums, n);

                if (indexN != nums.Length - 1)
                {
                    var testN = nums[indexN];
                    nums[indexN] = nums[indexN + 1];
                    nums[indexN + 1] = testN;
                    counter++;
                }
            }

            return counter;
        }
    }
}
