using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheNumberOfGoodPairsI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheNumberOfGoodPairsI(new int[] { 7, 13, 5, 14 }, new int[] { 13, 5, 7, 3 }, 1));
            Console.WriteLine(FindTheNumberOfGoodPairsI(new int[] { 2, 12 }, new int[] { 4, 3 }, 4));
            Console.WriteLine(FindTheNumberOfGoodPairsI(new int[] { 1, 3, 4 }, new int[] { 1, 3, 4 }, 1));
            Console.WriteLine(FindTheNumberOfGoodPairsI(new int[] { 1, 2, 4, 12 }, new int[] { 2, 4 }, 3));
        }
        public static int FindTheNumberOfGoodPairsI(int[] nums1, int[] nums2, int k)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            int n = nums1.Length, m = nums2.Length;
            int resCount = 0;
            int left = 0, right = 0;
            while (left < n)
            {
                if (right >= m || nums1[left] < nums2[right] * k)
                {
                    left++;
                    right = 0;
                }
                else if (nums1[left] % (nums2[right] * k) == 0)
                {
                    resCount++;
                    right++;
                }
                else if (nums1[left] > nums2[right] * k)
                    right++;
            }
            return resCount;
        }
    }
}
