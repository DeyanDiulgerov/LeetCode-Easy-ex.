using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumCommonValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumCommonValue(new int[] { 1, 2, 3 }, new int[] { 2, 4 }));
            Console.WriteLine(MinimumCommonValue(new int[] { 1, 2, 3, 6 }, new int[] { 2, 3, 4, 5 }));
        }

        public static int MinimumCommonValue(int[] nums1, int[] nums2)
        {
            var allCommonsList = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums2.Contains(nums1[i]))
                    allCommonsList.Add(nums1[i]);
            }

            if (allCommonsList.Count > 0)
            {
                allCommonsList.Sort();
                return allCommonsList.First();
            }
            else
                return -1;
        }

    }
}
