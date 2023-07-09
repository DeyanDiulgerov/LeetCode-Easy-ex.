using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinMaxGame(new int[] { 1, 3, 5, 2, 4, 8, 2, 2 }));
            Console.WriteLine(MinMaxGame(new int[] { 3 }));
        }

        public static int MinMaxGame(int[] nums)
        {
            int n = nums.Length;
            if (n == 1)
                return nums[0];

            int[] newNums = new int[n / 2];

            while (nums.Length != 1)
            {
                for (int i = 0; i < nums.Length / 2; i++)
                {
                    if (i % 2 == 0)
                        newNums[i] = Math.Min(nums[2 * i], nums[2 * i + 1]);
                    else if (i % 2 != 0)
                        newNums[i] = Math.Max(nums[2 * i], nums[2 * i + 1]);

                }

                nums = newNums;
                newNums = new int[newNums.Length / 2];
            }

            return nums[0];
        }
    }
}
