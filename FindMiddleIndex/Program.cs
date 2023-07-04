using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMiddleIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindMiddleIndex(new int[] { 2, 3, -1, 8, 4 }));
            Console.WriteLine(FindMiddleIndex(new int[] { 1, -1, 4 }));
            Console.WriteLine(FindMiddleIndex(new int[] { 2, 5 }));
        }

        public static int FindMiddleIndex(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                if (i > 0)
                {
                    for (int k = i - 1; k >= 0; k--)
                    {
                        leftSum += nums[k];
                    }
                }
                if (i < nums.Length - 1)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        rightSum += nums[j];
                    }
                }
                if (leftSum == rightSum)
                    return i;
            }

            return -1;
        }
    }
}
