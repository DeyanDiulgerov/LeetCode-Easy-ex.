using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTargetArrayInGivenOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",",
                CreateTargetArrayInGivenOrder(new int[] { 0, 1, 2, 3, 4 }, new int[] { 0, 1, 2, 2, 1 })));

            Console.WriteLine(String.Join(",",
                CreateTargetArrayInGivenOrder(new int[] { 1, 2, 3, 4, 0 }, new int[] { 0, 1, 2, 3, 0 })));
        }

        public static int[] CreateTargetArrayInGivenOrder(int[] nums, int[] index)
        {
            var result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                result.Insert(index[i], nums[i]);
            }

            return result.ToArray();
        }
    }
}
