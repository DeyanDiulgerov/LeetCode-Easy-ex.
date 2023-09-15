using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonotonicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MonotonicArray(new int[] { 1, 2, 2, 3 }));
            Console.WriteLine(MonotonicArray(new int[] { 6, 5, 4, 4 }));
            Console.WriteLine(MonotonicArray(new int[] { 1, 3, 2 }));
            Console.WriteLine(MonotonicArray(new int[] { 1, 1, 1 }));
        }

        public static bool MonotonicArray(int[] nums)
        {
            if (nums.All(x => x == nums.First()))
                return true;

            var firstNum = nums.First();
            var lastNum = nums.Last();

            if (firstNum > lastNum)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] < nums[i + 1])
                        return false;
                }
            }
            else if (firstNum < lastNum)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                        return false;
                }
            }
            else
                return false;

            return true;
        }
    }
}
