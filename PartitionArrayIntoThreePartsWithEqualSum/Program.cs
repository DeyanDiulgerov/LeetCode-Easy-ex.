using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitionArrayIntoThreePartsWithEqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PartitionArrayIntoThreePartsWithEqualSum(new int[] { 0, 2, 1, -6, 6, -7, 9, 1, 2, 0, 1 }));
            Console.WriteLine(PartitionArrayIntoThreePartsWithEqualSum(new int[] { 0, 2, 1, -6, 6, 7, 9, -1, 2, 0, 1 }));
            Console.WriteLine(PartitionArrayIntoThreePartsWithEqualSum(new int[] { 3, 3, 6, 5, -2, 2, 5, 1, -9, 4 }));

        }
        public static bool PartitionArrayIntoThreePartsWithEqualSum(int[] arr)
        {
            if (arr.Sum() % 3 != 0)
                return false;

            int average = arr.Sum() / 3;
            int count = 0;
            var sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (sum == average)
                {
                    count++;
                    sum = 0;
                }
            }

            return count >= 3;
        }
    }
}
