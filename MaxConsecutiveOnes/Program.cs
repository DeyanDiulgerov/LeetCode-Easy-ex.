using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxConsecutiveOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 }));
            Console.WriteLine(MaxConsecutiveOnes(new int[] { 1, 0, 1, 1, 0, 1 }));
        }

        public static int MaxConsecutiveOnes(int[] nums)
        {
            int counter = 0;
            int max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                    counter++;
                else
                    counter = 0;

                max = Math.Max(counter, max);
            }

            return max;
        }
    }
}
