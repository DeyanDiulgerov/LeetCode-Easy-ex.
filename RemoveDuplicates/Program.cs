using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveDuplicates(new int[] { 1, 1, 2 }));
            Console.WriteLine(RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int i = 1;

            foreach (int n in nums)
                if (nums[i - 1] != n)
                    nums[i++] = n;

            return i;
        }
    }
}
