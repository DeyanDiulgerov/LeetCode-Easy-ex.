using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayByParity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SortArrayByParity(new int[] { 3, 1, 2, 4 })));
            Console.WriteLine(String.Join(",", SortArrayByParity(new int[] { 0 })));
        }

        public static int[] SortArrayByParity(int[] nums)
        {
            var evenList = new List<int>();
            var oddList = new List<int>();
            var retList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                    evenList.Add(nums[i]);
                else
                    oddList.Add(nums[i]);
            }

            retList.AddRange(evenList);
            retList.AddRange(oddList);

            return retList.ToArray();
        }
    }
}
