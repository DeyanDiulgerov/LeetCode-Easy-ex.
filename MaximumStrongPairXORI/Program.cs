using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumStrongPairXORI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", MaximumStrongPairXORI(new int[] { 1, 1, 10, 3, 9 })));
            Console.WriteLine(String.Join(",", MaximumStrongPairXORI(new int[] { 1, 2, 3, 4, 5 })));
            Console.WriteLine(String.Join(",", MaximumStrongPairXORI(new int[] { 10, 100 })));
            Console.WriteLine(String.Join(",", MaximumStrongPairXORI(new int[] { 5, 6, 25, 30 })));
        }
        public static int MaximumStrongPairXORI(int[] nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) <= Math.Min(nums[i], nums[j]))
                        max = Math.Max(max, nums[i] ^ nums[j]);
                }
            }
            return max;
        }
    }
}
