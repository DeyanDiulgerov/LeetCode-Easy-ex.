using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSmallestNumberFromTwoDigitArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FormSmallestNumberFromTwoDigitArrays(new int[] { 7, 5, 6 }, new int[] { 1, 4 }));
            Console.WriteLine(FormSmallestNumberFromTwoDigitArrays(new int[] { 4, 1, 3 }, new int[] { 5, 7 }));
            Console.WriteLine(FormSmallestNumberFromTwoDigitArrays(new int[] { 3, 5, 2, 6 }, new int[] { 3, 1, 7 }));
        }
        public static int FormSmallestNumberFromTwoDigitArrays(int[] nums1, int[] nums2)
        {
            var allNumsList = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    string testNum = "";

                    if (nums1[i] == nums2[j])
                        allNumsList.Add(nums1[i]);
                    else
                    {
                        testNum += nums1[i].ToString() + nums2[j].ToString();
                        allNumsList.Add(int.Parse(testNum));
                    }
                }
            }
            for (int j = 0; j < nums2.Length; j++)
            {
                for (int i = 0; i < nums1.Length; i++)
                {
                    string testNum = "";

                    if (nums1[i] == nums2[j])
                        allNumsList.Add(nums1[i]);
                    else
                    {
                        testNum += nums2[j].ToString() + nums1[i].ToString();
                        allNumsList.Add(int.Parse(testNum));
                    }
                }
            }

            allNumsList.Sort();
            return allNumsList.First();
        }
    }
}
