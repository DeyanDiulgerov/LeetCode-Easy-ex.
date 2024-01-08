using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfBitwiseORHasTrailingZeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfBitwiseORHasTrailingZeroes(new int[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine(CheckIfBitwiseORHasTrailingZeroes(new int[] { 2, 4, 8, 16 }));
            Console.WriteLine(CheckIfBitwiseORHasTrailingZeroes(new int[] { 1, 3, 5, 7, 9 }));
        }
        public static bool CheckIfBitwiseORHasTrailingZeroes(int[] nums)
        {
            int trailingZeroes = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                string str = Convert.ToString(nums[i], 2);
                if (str.EndsWith("0"))
                    trailingZeroes++;

                if (trailingZeroes >= 2)
                    return true;
            }
            return false;
        }
    }
}
