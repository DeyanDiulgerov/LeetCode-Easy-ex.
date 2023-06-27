using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", IntersectionOfTwoArrays(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 })));
            Console.WriteLine(String.Join(",", IntersectionOfTwoArrays(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 })));
        }

        public static int[] IntersectionOfTwoArrays(int[] nums1, int[] nums2)
        {
            var listedNums = new List<int>();
            var retList = new List<int>();

            foreach (var item in nums1)
                listedNums.Add(item);

            foreach (var item in nums2)
            {
                if (listedNums.Contains(item) && !retList.Contains(item))
                {
                    retList.Add(item);
                    listedNums.Remove(item);
                }
            }

            return retList.ToArray();
        }
    }
}
