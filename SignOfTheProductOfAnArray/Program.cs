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
            int negativeCount = 0;

            foreach (var num in nums)
            {
                if (num == 0)
                    return 0;

                if (num < 0)
                    negativeCount++;
            }

            return (negativeCount % 2 == 0) ? 1 : -1;
        }
    }
}
