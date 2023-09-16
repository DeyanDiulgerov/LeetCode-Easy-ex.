using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSpecialQuadruplets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSpecialQuadruplets(new int[] { 1, 2, 3, 6 }));
            Console.WriteLine(CountSpecialQuadruplets(new int[] { 3, 3, 6, 4, 5 }));
            Console.WriteLine(CountSpecialQuadruplets(new int[] { 1, 1, 1, 3, 5 }));
        }

        public static int CountSpecialQuadruplets(int[] nums)
        {
            int counter = 0;

            for (int a = 0; a < nums.Length - 3; a++)
            {
                for (int b = a + 1; b < nums.Length - 2; b++)
                {
                    for (int c = b + 1; c < nums.Length - 1; c++)
                    {
                        for (int d = c + 1; d < nums.Length; d++)
                        {
                            if (nums[a] + nums[b] + nums[c] == nums[d])
                                counter++;
                        }
                    }
                }
            }
            return counter;
        }
    }
}
