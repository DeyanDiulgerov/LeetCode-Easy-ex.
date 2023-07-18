using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortIntByNumberOf1Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SortIntByNumberOf1Bits(new int[] { 10, 100, 1000, 10000 })));
            Console.WriteLine(String.Join(",", SortIntByNumberOf1Bits(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 })));
            Console.WriteLine(String.Join(",", SortIntByNumberOf1Bits(new int[] { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 })));
        }

        public static int[] SortIntByNumberOf1Bits(int[] arr)
             => arr.OrderBy(p => GetNumberOfBits(p)).ThenBy(p => p).ToArray();

        private static int GetNumberOfBits(int n)
        {
            var bitValue = 0;
            while (n > 0)
            {
                bitValue += n % 2;
                n /= 2;
            }
            return bitValue;
        }
    }
}
