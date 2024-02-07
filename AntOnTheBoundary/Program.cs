using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntOnTheBoundary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AntOnTheBoundary(new int[] { 2, 3, -5 }));
            Console.WriteLine(AntOnTheBoundary(new int[] { 3, 2, -3, -4 }));
        }
        public static int AntOnTheBoundary(int[] nums)
        {
            int result = 0, sum = 0, negativeSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    sum += nums[i];
                else
                    negativeSum += nums[i];
                if (sum == -negativeSum)
                    result++;
            }
            return result;
        }
    }
}
