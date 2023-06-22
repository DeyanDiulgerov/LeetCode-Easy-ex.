using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumCountPositiveAndNegativeInts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumCountPositiveAndNegativeInts(new int[] { -2, -1, -1, 1, 2, 3 }));
            Console.WriteLine(MaximumCountPositiveAndNegativeInts(new int[] { -3, -2, -1, 0, 0, 1, 2 }));
            Console.WriteLine(MaximumCountPositiveAndNegativeInts(new int[] { 5, 20, 66, 1314 }));

        }

        public static int MaximumCountPositiveAndNegativeInts(int[] nums)
        {
            int negativeCounter = 0;
            int positiveCounter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                    negativeCounter++;
                else if (nums[i] > 0)
                    positiveCounter++;
            }

            return Math.Max(negativeCounter, positiveCounter);
        }
    }
}
