using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeArrayZeroBySubstractingEqualAmounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakeArrayZeroBySubstractingEqualAmounts(new int[] { 1, 5, 0, 3, 5 }));
            Console.WriteLine(MakeArrayZeroBySubstractingEqualAmounts(new int[] { 0 }));
            Console.WriteLine(MakeArrayZeroBySubstractingEqualAmounts(new int[] { 7, 24, 28, 56 }));
            Console.WriteLine(MakeArrayZeroBySubstractingEqualAmounts(new int[] { 0, 0, 0, 1 }));
            Console.WriteLine(MakeArrayZeroBySubstractingEqualAmounts(new int[] { 1, 2, 3, 4 }));
        }

        public static int MakeArrayZeroBySubstractingEqualAmounts(int[] nums)
        {
            return nums.Where(x => x != 0).Distinct().Count();
        }
    }
}
