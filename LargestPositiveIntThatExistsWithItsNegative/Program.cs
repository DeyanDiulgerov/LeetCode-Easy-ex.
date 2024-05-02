using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPositiveIntThatExistsWithItsNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestPositiveIntThatExistsWithItsNegative(new int[] { -1, 2, -3, 3 }));
            Console.WriteLine(LargestPositiveIntThatExistsWithItsNegative(new int[] { -1, 10, 6, 7, -7, 1 }));
            Console.WriteLine(LargestPositiveIntThatExistsWithItsNegative(new int[] { -10, 8, 6, 7, -2, -3 }));
        }

        public static int LargestPositiveIntThatExistsWithItsNegative(int[] nums)
        {
            var seen = new HashSet<int>();
            foreach (int num in nums)
                if (nums.Contains(-num))
                {
                    if (num < 0)
                        seen.Add(-num);
                    else
                        seen.Add(num);
                }
            return seen.Count != 0 ? seen.Max() : -1;
        }
    }
}
