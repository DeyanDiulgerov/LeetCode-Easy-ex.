using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindGreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindGreatestCommonDivisor(new int[] { 48, 20, 30, 12, 41 }));
            Console.WriteLine(FindGreatestCommonDivisor(new int[] { 5, 8, 10 }));
            Console.WriteLine(FindGreatestCommonDivisor(new int[] { 2, 5, 6, 9, 10 }));
            Console.WriteLine(FindGreatestCommonDivisor(new int[] { 7, 5, 6, 8, 3 }));
            Console.WriteLine(FindGreatestCommonDivisor(new int[] { 3, 3 }));
            Console.WriteLine(FindGreatestCommonDivisor(new int[] { 8, 5, 8, 7, 4 }));
        }

        public static int FindGreatestCommonDivisor(int[] nums)
        {
            Array.Sort(nums);
            var smallest = nums.First();
            var largest = nums.Last();

            int max = 1;
            int divisor = 2;

            for (int i = 0; i < largest + 1; i++)
            {
                if (smallest % divisor == 0 && largest % divisor == 0 && divisor > max)
                {
                    max = divisor;
                }

                divisor++;
            }

            return max;
        }
    }
}
