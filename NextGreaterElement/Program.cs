using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGreaterElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",",
                NextGreaterElement(new int[] { 1, 3, 5, 2, 4 }, new int[] { 6, 5, 4, 3, 2, 1, 7 })));

            Console.WriteLine(String.Join(",",
                NextGreaterElement(new int[] { 4, 1, 2 }, new int[] { 1, 3, 4, 2 })));

            Console.WriteLine(String.Join(",",
                NextGreaterElement(new int[] { 2, 4 }, new int[] { 1, 2, 3, 4 })));
        }

        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var retList = new List<int>(nums1.Length);
            int maxNum = 0;

            for (int i = 0; i < nums1.Length; i++)
            {
                var index = nums2.ToList().IndexOf(nums1[i]);
                maxNum = 0;

                if (index < nums2.Length - 1)
                {
                    for (int j = index + 1; j < nums2.Length; j++)
                    {
                        if (nums2[j] > nums2[index] && nums2[j] > maxNum)
                        {
                            maxNum = nums2[j];
                            break;
                        }
                        else
                            maxNum = -1;
                    }

                    retList.Add(maxNum);
                }
                else
                    retList.Add(-1);
            }

            return retList.ToArray();
        }
    }
}
