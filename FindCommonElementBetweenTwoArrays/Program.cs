using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCommonElementBetweenTwoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FindCommonElementBetweenTwoArrays(
                new int[] { 4, 3, 2, 3, 1 }, new int[] { 2, 2, 5, 2, 3, 6 })));
            Console.WriteLine(String.Join(",", FindCommonElementBetweenTwoArrays(
                new int[] { 3, 4, 2, 3 }, new int[] { 1, 5 })));
        }
        public static int[] FindCommonElementBetweenTwoArrays(int[] nums1, int[] nums2)
        {
            var seenCount = 0;
            int n = nums1.Length;
            int m = nums2.Length;
            var result = new int[2];

            for (int i = 0; i < n; i++)
            {
                if (nums2.Contains(nums1[i]))
                    seenCount++;
            }

            result[0] = seenCount;
            seenCount = 0;

            for (int i = 0; i < m; i++)
            {
                if (nums1.Contains(nums2[i]))
                    seenCount++;
            }
            result[1] = seenCount;
            return result;
        }
    }
}
