using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoOutOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", TwoOutOfThree(new int[] { 2, 15, 10, 11, 14, 12, 14, 11, 9, 1 },
                new int[] { 8, 9, 13, 2, 11, 8 }, new int[] { 13, 5, 15, 7, 12, 7, 8, 3, 13, 15 })));

            Console.WriteLine(String.Join(",", TwoOutOfThree(new int[] { 1, 1, 3, 2 },
                new int[] { 2, 3 }, new int[] { 3 })));

            Console.WriteLine(String.Join(",", TwoOutOfThree(new int[] { 3, 1 },
                new int[] { 2, 3 }, new int[] { 1, 2 })));

            Console.WriteLine(String.Join(",", TwoOutOfThree(new int[] { 1, 2, 2 },
                new int[] { 4, 3, 3 }, new int[] { 5 })));

        }

        public static IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
        {
            var retList = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (!retList.Contains(nums1[i]) && (nums2.Contains(nums1[i]) || nums3.Contains(nums1[i])))
                    retList.Add(nums1[i]);
            }

            for (int i = 0; i < nums3.Length; i++)
            {
                if (nums2.Contains(nums3[i]) && !retList.Contains(nums3[i]))
                    retList.Add(nums3[i]);
            }

            return retList;
        }
    }
}
