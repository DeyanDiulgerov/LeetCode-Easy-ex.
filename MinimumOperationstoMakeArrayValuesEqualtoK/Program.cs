using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumOperationstoMakeArrayValuesEqualtoK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumOperationstoMakeArrayValuesEqualtoK(new int[] { 5, 2, 5, 4, 5 }, 2));
            Console.WriteLine(MinimumOperationstoMakeArrayValuesEqualtoK(new int[] { 2, 1, 2 }, 2));
            Console.WriteLine(MinimumOperationstoMakeArrayValuesEqualtoK(new int[] { 9, 7, 5, 3 }, 1));
        }

        public static int MinimumOperationstoMakeArrayValuesEqualtoK(int[] nums, int k)
        {
            if (nums.Min() < k)
                return -1;
            int resOperations = 0;
            int h = k - 1;
            while (nums.Distinct().Count() != 1 || (nums[0] != k && nums[nums.Length - 1] != 1))
            {
                h++;
                if (nums.Distinct().Count(x => x > h) == 1)
                {
                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] > h)
                            nums[i] = h;
                    }
                    resOperations++;

                    h = k - 1;
                }
            }
            return resOperations;
        }
    }
}
