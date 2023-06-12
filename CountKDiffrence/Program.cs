using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountKDiffrence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountKDiffrence(new int[] { 1, 2, 2, 1 }, 1));
            Console.WriteLine(CountKDiffrence(new int[] { 1, 3 }, 3));
            Console.WriteLine(CountKDiffrence(new int[] { 3, 2, 1, 5, 4 }, 2));
        }

        public static int CountKDiffrence(int[] nums, int k)
        {
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j && nums[i] - nums[j] == k)
                        counter++;
                }
            }

            return counter;
        }
    }
}
