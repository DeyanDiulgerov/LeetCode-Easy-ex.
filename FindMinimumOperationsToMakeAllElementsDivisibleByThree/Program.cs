using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMinimumOperationsToMakeAllElementsDivisibleByThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindMinimumOperationsToMakeAllElementsDivisibleByThree(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(FindMinimumOperationsToMakeAllElementsDivisibleByThree(new int[] { 3, 6, 9 }));
        }
        public static int FindMinimumOperationsToMakeAllElementsDivisibleByThree(int[] nums)
        {
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 3 != 0)
                    res++;
            }
            return res;
        }
    }
}
