using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepMultiplyingFinalValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KeepMultiplyingFinalValue(new int[] { 5, 3, 6, 1, 12 }, 3));
            Console.WriteLine(KeepMultiplyingFinalValue(new int[] { 2, 7, 9 }, 4));
        }

        public static int KeepMultiplyingFinalValue(int[] nums, int original)
        {
            if (!nums.Contains(original))
                return original;

            while (nums.Contains(original))
            {
                original = original * 2;
            }

            return original;
        }
    }
}
