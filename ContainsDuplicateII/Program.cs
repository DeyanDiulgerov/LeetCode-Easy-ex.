using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsDuplicateII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContainsDuplicateII(new int[] { 1, 2, 3, 1 }, 3));
            Console.WriteLine(ContainsDuplicateII(new int[] { 1, 0, 1, 1 }, 1));
            Console.WriteLine(ContainsDuplicateII(new int[] { 1, 2, 3, 1, 2, 3 }, 2));
        }

        public static bool ContainsDuplicateII(int[] nums, int k)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int j = i + 1;
                while (j < nums.Length && Math.Abs(i - j) <= k)
                {
                    if (nums[i] == nums[j])
                        return true;

                    j++;
                }
            }
            return false;
        }
    }
}
