using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPositiveIntThatExistsWithItsNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestPositiveIntThatExistsWithItsNegative(new int[] { -1, 2, -3, 3 }));
            Console.WriteLine(LargestPositiveIntThatExistsWithItsNegative(new int[] { -1, 10, 6, 7, -7, 1 }));
            Console.WriteLine(LargestPositiveIntThatExistsWithItsNegative(new int[] { -10, 8, 6, 7, -2, -3 }));
        }

        public static int LargestPositiveIntThatExistsWithItsNegative(int[] nums)
        {
            var listedNums = new List<int>(nums);
            listedNums.Sort();

            for (int i = 0; i < nums.Length; i++)
            {
                var maxNum = listedNums.Last();

                if (listedNums.Contains(-maxNum))
                    return maxNum;

                listedNums.Remove(maxNum);
            }

            return -1;
        }
    }
}
