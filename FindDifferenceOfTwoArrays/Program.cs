using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDifferenceOfTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer1 = FindDifferenceOfTwoArrays(new int[] { 1, 2, 3 }, new int[] { 2, 4, 6 });
            var answer2 = FindDifferenceOfTwoArrays(new int[] { 1, 2, 3, 3 }, new int[] { 1, 1, 2, 2 });

            foreach (var item in answer1)
            {
                Console.WriteLine(String.Join(",", item));
            }
            foreach (var item in answer2)
            {
                Console.WriteLine(String.Join(",", item));
            }

        }

        public static List<IList<int>> FindDifferenceOfTwoArrays(int[] nums1, int[] nums2)
        {
            var result = new List<IList<int>>(2);
            var newList = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (!nums2.Contains(nums1[i]) && !newList.Contains(nums1[i]))
                    newList.Add(nums1[i]);
            }
            result.Add(newList);
            newList = new List<int>();

            for (int j = 0; j < nums2.Length; j++)
            {
                if (!nums1.Contains(nums2[j]) && !newList.Contains(nums2[j]))
                    newList.Add(nums2[j]);
            }

            result.Add(newList);

            return result;
        }
    }
}
