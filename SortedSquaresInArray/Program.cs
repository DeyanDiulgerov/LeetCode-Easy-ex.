using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSquaresInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SortedSquaresInArray(new int[] { -4, -1, 0, 3, 10 })));
            Console.WriteLine(String.Join(",", SortedSquaresInArray(new int[] { -7, -3, 2, 3, 11 })));
        }
        //Two Pointers
         public static int[] SortedSquares(int[] nums)
        {
            int n = nums.Length;
            int left = 0, right = n - 1;
            var resultArr = new int[n];
            int index = n - 1;

            while (left <= right)
            {
                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    resultArr[index] = nums[left] * nums[left];
                    left++;
                }
                else
                {
                    resultArr[index] = nums[right] * nums[right];
                    right--;
                }
                index--;
            }
            return resultArr;
        }
        // Trivial Way
        public static int[] SortedSquaresInArray(int[] nums)
        {
            var retList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                retList.Add(nums[i] * nums[i]);
            }

            retList.Sort();

            return retList.ToArray();
        }
        
    }
}
