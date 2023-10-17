using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPivotIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindPivotIndex(new int[] { 1, 7, 3, 6, 5, 6 }));
            Console.WriteLine(FindPivotIndex(new int[] { 1, 2, 3 }));
            Console.WriteLine(FindPivotIndex(new int[] { 2, 1, -1 }));
        }

        public static int FindPivotIndex(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var leftSum = 0;
                var rightSum = 0;
                int l = i - 1;
                int r = i + 1;

                while (r < nums.Length)
                {
                    rightSum += nums[r];
                    r++;
                }
                while (l >= 0)
                {
                    leftSum += nums[l];
                    l--;
                }

                if (leftSum == rightSum)
                    return i;
            }
            return -1;
        }
    }
}
