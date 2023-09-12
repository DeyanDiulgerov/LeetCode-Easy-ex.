using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumDistanceToTheTargetElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumDistanceToTheTargetElement(new int[] { 5, 2, 3, 5, 5 }, 5, 2));
            Console.WriteLine(MinimumDistanceToTheTargetElement(new int[] { 1, 5, 3, 4, 5 }, 5, 2));
            Console.WriteLine(MinimumDistanceToTheTargetElement(new int[] { 5, 3, 6 }, 5, 2));
            Console.WriteLine(MinimumDistanceToTheTargetElement(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 1, 9));
            Console.WriteLine(MinimumDistanceToTheTargetElement(new int[] { 1, 2, 3, 4, 5 }, 5, 3));
            Console.WriteLine(MinimumDistanceToTheTargetElement(new int[] { 1 }, 1, 0));
            Console.WriteLine(MinimumDistanceToTheTargetElement(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 1, 0));
        }

        public static int MinimumDistanceToTheTargetElement(int[] nums, int target, int start)
        {
            int min = nums.Max();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    min = Math.Min(min, Math.Abs(i - start));
                }
            }
            return min;
        }
    }
}
