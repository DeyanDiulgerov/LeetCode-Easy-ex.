using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumDifferenceBetweenIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumDifferenceBetweenIncreasingElements(new int[] { 7, 1, 5, 4 }));
            Console.WriteLine(MaximumDifferenceBetweenIncreasingElements(new int[] { 9, 4, 3, 2 }));
            Console.WriteLine(MaximumDifferenceBetweenIncreasingElements(new int[] { 1, 5, 2, 10 }));
        }

        public static int MaximumDifferenceBetweenIncreasingElements(int[] nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        var newMax = nums[j] - nums[i];
                        max = Math.Max(max, newMax);
                    }
                }
            }

            if (max > 0)
                return max;
            else
                return -1;
        }
    }
}
