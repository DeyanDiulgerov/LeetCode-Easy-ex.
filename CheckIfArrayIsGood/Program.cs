using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfArrayIsGood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfArrayIsGood(new int[] { 2, 1, 3 }));
            Console.WriteLine(CheckIfArrayIsGood(new int[] { 1, 3, 3, 2 }));
            Console.WriteLine(CheckIfArrayIsGood(new int[] { 1, 1 }));
            Console.WriteLine(CheckIfArrayIsGood(new int[] { 3, 4, 4, 1, 2, 1 }));
        }
        public static bool CheckIfArrayIsGood(int[] nums)
        {
            Array.Sort(nums);
            var n = nums.Last();

            var baseN = new int[n + 1];

            for (int i = 0; i < n; i++)
            {
                baseN[i] = i + 1;
            }

            baseN[n - 1] = n;
            baseN[n] = n;

            if (nums.Length != baseN.Length)
                return false;
            else
            {
                Array.Sort(baseN);

                if (!baseN.SequenceEqual(nums))
                    return false;
                else
                    return true;
            }
        }
    }
}
