using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountPairs(new int[] { 3, 1, 2, 2, 2, 1, 3 }, 2));
            Console.WriteLine(CountPairs(new int[] { 1, 2, 3, 4 }, 1));
        }

        public static int CountPairs(int[] nums, int k)
        {
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i * j % k == 0)
                        counter++;
                }
            }

            return counter;
        }
    }
}
