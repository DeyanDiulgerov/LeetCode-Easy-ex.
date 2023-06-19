using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinOperationsIncreasingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinOperationsIncreasingArray(new int[] { 1, 1, 1 }));
            Console.WriteLine(MinOperationsIncreasingArray(new int[] { 1, 5, 2, 4, 1 }));
            Console.WriteLine(MinOperationsIncreasingArray(new int[] { 8 }));

        }

        public static int MinOperationsIncreasingArray(int[] nums)
        {
            if (nums.Length == 1)
                return 0;

            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    while (nums[i] >= nums[j])
                    {
                        nums[j]++;
                        counter++;
                    }
                }
            }

            return counter;
        }
    }
}
