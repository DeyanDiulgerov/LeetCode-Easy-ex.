using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximizeSumOfArrayAfterKNegations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximizeSumOfArrayAfterKNegations(new int[] { -2, 9, 9, 8, 4 }, 5));
                                                                          //-2, 4, 8, 9, 9
            Console.WriteLine(MaximizeSumOfArrayAfterKNegations(new int[] { -8, 3, -5, -3, -5, -2 }, 6));
                                                                          //-8,-5,-5,-3,-2, 3
            Console.WriteLine(MaximizeSumOfArrayAfterKNegations(new int[] { 4, 2, 3 }, 1));
            Console.WriteLine(MaximizeSumOfArrayAfterKNegations(new int[] { 1, 3, 2, 6, 7, 9 }, 3));
            Console.WriteLine(MaximizeSumOfArrayAfterKNegations(new int[] { 2, -3, -1, 5, -4 }, 2));
            Console.WriteLine(MaximizeSumOfArrayAfterKNegations(new int[] { 3, -1, 0, 2 }, 3));
        }
        public static int MaximizeSumOfArrayAfterKNegations(int[] nums, int k)
        {
            Array.Sort(nums);
            var permNums = nums;
            int counter = 0;

            while (counter < k)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums.All(x => x >= 0) && nums.Contains(0))
                        return nums.Sum();
                    if (counter >= k)
                        break;

                    if (nums.Count(x => x <= 0) <= 1)
                    {
                        Array.Sort(nums);
                        var test = nums.First();
                        var index = Array.IndexOf(permNums, test);
                        nums = permNums;
                        nums[index] = -nums[index];
                        counter++;
                        continue;
                    }
                    else if (nums[i] < 0)
                        nums[i] = -nums[i];

                    counter++;
                }
            }

            return nums.Sum();
        }
    }
}
