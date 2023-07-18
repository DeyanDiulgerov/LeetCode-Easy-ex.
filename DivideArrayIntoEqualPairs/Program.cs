using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideArrayIntoEqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DivideArrayIntoEqualPairs
                (new int[] { 9, 4, 18, 3, 2, 6, 18, 15, 7, 15, 6, 4, 15,
                    14, 7, 4, 15, 4, 3, 17, 9, 13, 13, 12, 2, 14, 12, 17 }));

            Console.WriteLine(DivideArrayIntoEqualPairs(new int[] { 3, 2, 3, 2, 2, 2 }));
            Console.WriteLine(DivideArrayIntoEqualPairs(new int[] { 1, 2, 3, 4 }));
        }

        public static bool DivideArrayIntoEqualPairs(int[] nums)
        {
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i += 2)
            {
                if (i < nums.Length - 1)
                {
                    if (nums[i] != nums[i + 1])
                        return false;
                }
            }

            return true;
        }
    }
}
