using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestIndexWithEqualValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1 % 10);
            Console.WriteLine(2 % 10);
            Console.WriteLine(3 % 10);
            Console.WriteLine(4 % 10);

            Console.WriteLine(String.Join(",", SmallestIndexWithEqualValue(new int[] { 0, 1, 2 })));
            Console.WriteLine(String.Join(",", SmallestIndexWithEqualValue(new int[] { 4, 3, 2, 1 })));
            Console.WriteLine(String.Join(",", SmallestIndexWithEqualValue(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 })));
        }

        public static int SmallestIndexWithEqualValue(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 10 == nums[i])
                    return i;
            }

            return -1;
        }
    }
}
