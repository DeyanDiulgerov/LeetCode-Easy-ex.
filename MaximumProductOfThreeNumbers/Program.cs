using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumProductOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumProductOfThreeNumbers(new int[] { -8, -7, -2, 10, 20 }));
            Console.WriteLine(MaximumProductOfThreeNumbers(new int[] { -313, 159, 193, }));
            Console.WriteLine(MaximumProductOfThreeNumbers(new int[] { -100, -2, -3, 1 }));
            Console.WriteLine(MaximumProductOfThreeNumbers(new int[] { -100, -98, -1, 2, 3, 4 }));
            Console.WriteLine(MaximumProductOfThreeNumbers(new int[] { 1, 2, 3 }));
            Console.WriteLine(MaximumProductOfThreeNumbers(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(MaximumProductOfThreeNumbers(new int[] { -1, -2, -3 }));
        }
        public static int MaximumProductOfThreeNumbers(int[] nums)
        {
            Array.Sort(nums);
            int n = nums.Length;
            int left = -1;
            int right = 1;

            if (nums[1] < 0 && 0 < nums[n - 1])
                left = nums[0] * nums[1] * nums[n - 1];
            else
                left = nums[n - 3] * nums[n - 2] * nums[n - 1];

            for (int i = n - 1; i > n - 4; i--)
                right *= nums[i];
            return Math.Max(right, left);
        }
    }
}
