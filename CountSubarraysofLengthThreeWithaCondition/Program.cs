using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubarraysofLengthThreeWithaCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSubarraysofLengthThreeWithaCondition(new int[] { -1, -4, -1, 4 }));
            Console.WriteLine(CountSubarraysofLengthThreeWithaCondition(new int[] { 1, 2, 1, 4, 1 }));
            Console.WriteLine(CountSubarraysofLengthThreeWithaCondition(new int[] { 1, 1, 1 }));
        }

        public static int CountSubarraysofLengthThreeWithaCondition(int[] nums)
        {
            int res = 0;
            int l = 0, r = 2;
            while (r < nums.Count())
            {
                int sum = nums[l] + nums[r];
                double divided = (double)nums[l + 1] / 2;
                if (sum == divided)
                    res++;
                l++;
                r++;
            }
            return res;
        }
    }
}
