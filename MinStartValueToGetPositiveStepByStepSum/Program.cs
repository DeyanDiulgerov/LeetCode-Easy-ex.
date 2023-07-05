using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinStartValueToGetPositiveStepByStepSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinStartValueToGetPositiveStepByStepSum(new int[] { -3, 2, -3, 4, 2 }));
            Console.WriteLine(MinStartValueToGetPositiveStepByStepSum(new int[] { 1, 2 }));
            Console.WriteLine(MinStartValueToGetPositiveStepByStepSum(new int[] { 1, -2, -3 }));
        }

        public static int MinStartValueToGetPositiveStepByStepSum(int[] nums)
        {
            int sum = 0;
            int min = 0;
            foreach (var num in nums)
            {
                sum += num;
                if (sum < min)
                    min = sum;
            }

            return -min + 1;
        }
    }
}
