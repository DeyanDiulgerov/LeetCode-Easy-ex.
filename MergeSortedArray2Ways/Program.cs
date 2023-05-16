using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortedArray2Ways
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            var nums2 = new int[] { 2, 5, 6 };
            int n = 3;



            Program.Merge2(nums1, m, nums2, n);
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m; i < nums1.Length; i++)
                nums1[i] = nums2[i - m];

            Array.Sort(nums1);

            Console.WriteLine(String.Join(",", nums1));
            Console.WriteLine(String.Join(",", nums2));
        }

        public static void Merge2(int[] nums1, int m, int[] nums2, int n)
        {
            //arrays sorted in non-decreasing order
            //m = count of elements in nums1 W/O 0;
            //n = count of elements in nums2 W/O 0;

            var list1 = new List<int>(nums1);
            var list2 = new List<int>(nums2);

            for (int i = 0; i < list2.Count(); i++)
            {
                list1.Add(list2[i]);
            }

            for (int i = 0; i < list1.Count(); i++)
            {
                if (list1[i] == 0)
                    list1.RemoveAll(x => x == 0);
            }

            list1.Sort();
            nums1 = list1.ToArray();
            Array.Sort(nums1);

            Console.WriteLine(String.Join(",", nums1));
            Console.WriteLine(String.Join(",", nums2));
        }
    }
}
