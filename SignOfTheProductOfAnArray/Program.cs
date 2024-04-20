using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfTheProductOfAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SignOfTheProductOfAnArray(new int[] { -1, -2, -3, -4, 3, 2, 1 }));
            Console.WriteLine(SignOfTheProductOfAnArray(new int[] { 1, 5, 0, 2, -3 }));
            Console.WriteLine(SignOfTheProductOfAnArray(new int[] { -1, 1, -1, 1, -1 }));
        }

        public static int SignOfTheProductOfAnArray(int[] nums)
        {
            if(nums.Any(x => x == 0))
                return 0;
            if(nums.Count(x => x < 0) % 2 != 0)
                return -1;
            return 1;
        }
    }
}
