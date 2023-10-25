using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumValueOfAnOrderedTripletI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumValueOfAnOrderedTripletI(new int[] { 1000000, 1, 1000000 }));
            Console.WriteLine(MaximumValueOfAnOrderedTripletI(new int[] { 12, 6, 1, 2, 7 }));
            Console.WriteLine(MaximumValueOfAnOrderedTripletI(new int[] { 1, 10, 3, 4, 19 }));
            Console.WriteLine(MaximumValueOfAnOrderedTripletI(new int[] { 1, 2, 3 }));
        }
        public static long MaximumValueOfAnOrderedTripletI(int[] nums)
        {
            long max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        long newMax = ((long)nums[i] - (long)nums[j]) * (long)nums[k];
                        max = Math.Max(max, newMax);
                    }
                }
            }
            return max;
        }
    }
}
