using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindIndicesWithIndexAndValueDiffrenceI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FindIndicesWithIndexAndValueDiffrenceI
                (new int[] { 5, 1, 4, 1 }, 2, 4)));
            Console.WriteLine(String.Join(",", FindIndicesWithIndexAndValueDiffrenceI
                (new int[] { 2, 1 }, 0, 0)));
            Console.WriteLine(String.Join(",", FindIndicesWithIndexAndValueDiffrenceI
                (new int[] { 1, 2, 3 }, 2, 4)));
        }

        public static int[] FindIndicesWithIndexAndValueDiffrenceI(int[] nums, int indexDifference, int valueDifference)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (Math.Abs(i - j) >= indexDifference
                    && Math.Abs(nums[i] - nums[j]) >= valueDifference)
                        return new int[] { i, j };
                }
            }

            return new int[] { -1, -1 };
        }
    }
}
