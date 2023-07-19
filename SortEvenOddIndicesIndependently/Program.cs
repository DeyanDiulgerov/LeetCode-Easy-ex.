using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortEvenOddIndicesIndependently
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SortEvenOddIndicesIndependently(
                new int[] { 5, 39, 33, 5, 12, 27, 20, 45, 14, 25, 32, 33, 30, 30, 9, 14, 44, 15, 21 })));
            Console.WriteLine(String.Join(",", SortEvenOddIndicesIndependently(
                new int[] { 36, 45, 32, 31, 15, 41, 9, 46, 36, 6, 15, 16, 33, 26, 27, 31, 44, 34 })));
            Console.WriteLine(String.Join(",", SortEvenOddIndicesIndependently(new int[] { 2, 1 })));
            Console.WriteLine(String.Join(",", SortEvenOddIndicesIndependently(new int[] { 4, 1, 2, 3 })));
        }

        public static int[] SortEvenOddIndicesIndependently(int[] nums)
        {
            if (nums.Length == 1)
                return nums;

            int n = nums.Length;
            var resultArr = new int[n];
            var oddList = new List<int>();
            var evenList = new List<int>();

            for (int i = 1; i < n; i += 2)
            {
                oddList.Add(nums[i]);
            }
            for (int i = 0; i < n; i += 2)
            {
                evenList.Add(nums[i]);
            }

            oddList.Sort();
            oddList.Reverse();
            evenList.Sort();

            resultArr[0] = evenList[0];
            resultArr[1] = oddList[0];

            int evenCounter = 1;
            int oddCounter = 1;

            for (int i = 2; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    resultArr[i] = evenList[evenCounter];
                    evenCounter++;
                }
                else if (i % 2 != 0)
                {
                    resultArr[i] = oddList[oddCounter];
                    oddCounter++;
                }
            }

            return resultArr;
        }
    }
}
