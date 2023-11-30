using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPerimeterTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestPerimeterTriangle(new int[] { 2, 1, 2 }));
            Console.WriteLine(LargestPerimeterTriangle(new int[] { 1, 2, 1, 10 }));
        }
        public static int LargestPerimeterTriangle(int[] nums)
        {
            Array.Sort(nums);
            int n = nums.Length;
            int max = 0;

            for (int i = 0; i < n - 2; i++)
            {
                int a = nums[i], b = nums[i + 1], c = nums[i + 2];

                if (a + b > c && a + c > b && b + c > a)
                {
                    var newPerimeter = a + b + c;
                    max = Math.Max(max, newPerimeter);
                }
            }
            return max;
        }
    }
}
