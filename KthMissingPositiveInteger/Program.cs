using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthMissingPositiveInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KthMissingPositiveInteger(new int[] { 2, 3, 4, 7, 11 }, 5));
            Console.WriteLine(KthMissingPositiveInteger(new int[] { 1, 2, 3, 4 }, 2));
        }

        public static int KthMissingPositiveInteger(int[] arr, int k)
        {
            var allNums = new List<int>();

            for (int i = 0; i < 10000; i++)
            {
                if (arr.Contains(i))
                    continue;
                else
                    allNums.Add(i);
            }

            return allNums[k];
        }
    }
}
