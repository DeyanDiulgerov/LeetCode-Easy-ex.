using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfAllSubsetXORTotals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfAllSubsetXORTotals(new int[] { 1, 3 }));
            Console.WriteLine(SumOfAllSubsetXORTotals(new int[] { 5, 1, 6 }));
            Console.WriteLine(SumOfAllSubsetXORTotals(new int[] { 3, 4, 5, 6, 7, 8 }));
        }

        public static int SumOfAllSubsetXORTotals(int[] nums)
        {
            return SubsetXORSumUntil(nums, 0, 0);
        }

        public static int SubsetXORSumUntil(int[] nums, int idx, int xor)
        {
            if (idx == nums.Length)
                return xor;

            return SubsetXORSumUntil(nums, idx + 1, xor ^ nums[idx]) + SubsetXORSumUntil(nums, idx + 1, xor);
        }
    }
}
