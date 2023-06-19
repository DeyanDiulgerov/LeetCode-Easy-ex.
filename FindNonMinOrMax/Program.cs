using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNonMinOrMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindNonMinOrMax(new int[] { 3, 2, 1, 4 }));
            Console.WriteLine(FindNonMinOrMax(new int[] { 1, 2 }));
            Console.WriteLine(FindNonMinOrMax(new int[] { 2, 1, 3 }));
        }

        public static int FindNonMinOrMax(int[] nums)
        {
            if (nums.Length == 1 || nums.Length == 2)
                return -1;

            var min = nums.Min();
            var max = nums.Max();

            return nums.Where(x => x != min && x != max).First();
        }
    }
}
