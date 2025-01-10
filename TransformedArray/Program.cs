using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", TransformedArray(new int[] { 3, -2, 1, 1 })));
            Console.WriteLine(String.Join(",", TransformedArray(new int[] { -1, 4, -1 })));
        }

        public static int[] TransformedArray(int[] nums)
        {
            int n = nums.Length;
            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                int j = i;
                int count = 0;
                if (nums[i] == 0)
                {
                    res[i] = nums[i];
                    continue;
                }
                else if (nums[i] > 0)
                {
                    count = nums[i];
                    while (count > 0)
                    {
                        j++;
                        if (j >= n)
                            j = 0;
                        count--;
                    }
                }
                else if (nums[i] < 0)
                {
                    count = Math.Abs(nums[i]);
                    while (count > 0)
                    {
                        j--;
                        if (j <= -1)
                            j = n - 1;
                        count--;
                    }
                }
                res[i] = nums[j];
            }
            return res;
        }
    }
}
