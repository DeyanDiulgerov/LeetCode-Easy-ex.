using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeInDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new int[][]
            {
                new int[] {1,2,3},
                new int[] {5,6,7},
                new int[] {9,10,11},
            };
            var nums2 = new int[][]
            {
                new int[] {1,2,3},
                new int[] {5,17,7},
                new int[] {9,10,11},
            };
            var nums3 = new int[][]
            {
                new int[] {1,2,17},
                new int[] {5,3,7},
                new int[] {9,10,11},
            };

            Console.WriteLine(PrimeInDiagonal(nums3));
            Console.WriteLine(PrimeInDiagonal(nums1));
            Console.WriteLine(PrimeInDiagonal(nums2));
        }

        public static int PrimeInDiagonal(int[][] nums)
        {
            var testNums = new List<int>() { };
            for (int i = 2; i <= 111; i++)
                testNums.Add(i);

            var ourPrimeNums = new List<int>();

            int startRow = 0;
            int startCol = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (testNums.Any(x => nums[startRow][startCol] % x == 0 && x != nums[startRow][startCol]))
                {

                }
                else
                    ourPrimeNums.Add(nums[startRow][startCol]);

                startRow++;
                startCol++;
            }

            startRow = nums.Length - 1;
            startCol = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (testNums.Any(x => nums[startRow][startCol] % x == 0 && x != nums[startRow][startCol]))
                {

                }
                else
                    ourPrimeNums.Add(nums[startRow][startCol]);

                startRow--;
                startCol++;
            }
            if (ourPrimeNums.Count() > 0 && ourPrimeNums.Max() == 1)
                return 0;
            else if (ourPrimeNums.Count() > 0)
                return ourPrimeNums.Max();
            else
                return 0;
        }
    }
}
