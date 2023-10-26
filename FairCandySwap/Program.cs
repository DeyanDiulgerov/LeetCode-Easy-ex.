using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairCandySwap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FairCandySwap(
                new int[] { 1, 1 }, new int[] { 2, 2 })));
            Console.WriteLine(String.Join(",", FairCandySwap(
                new int[] { 1, 2 }, new int[] { 2, 3 })));
            Console.WriteLine(String.Join(",", FairCandySwap(
                new int[] { 2 }, new int[] { 1, 3 })));
        }
        public static int[] FairCandySwap(int[] aliceSizes, int[] bobSizes)
        {
            var sumA = aliceSizes.Sum();
            var sumB = bobSizes.Sum();
            var result = new int[2];

            var diff = (sumB - sumA) / 2;

            for (int i = 0; i < aliceSizes.Length; i++)
            {
                if (bobSizes.Contains(aliceSizes[i] + diff))
                {
                    result[0] = aliceSizes[i];
                    result[1] = aliceSizes[i] + diff;
                    return result;
                }
            }
            return result;
        }
    }
}
