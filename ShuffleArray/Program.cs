using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", ShuffleArray(new int[] { 2, 5, 1, 3, 4, 7 }, 3)));
            Console.WriteLine(String.Join(",", ShuffleArray(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4)));
            Console.WriteLine(String.Join(",", ShuffleArray(new int[] { 1, 1, 2, 2 }, 2)));
        }


        public static int[] ShuffleArray(int[] nums, int n)
        {
            var xArr = new int[n];
            var yArr = new int[n];
            var resultList = new List<int>(nums.Length);

            for (int i = 0; i < n; i++)
            {
                yArr[i] += nums[i + n];
            }

            for (int i = 0; i < n; i++)
            {
                xArr[i] += nums[i];
            }

            for (int i = 0; i < n; i++)
            {
                resultList.Add(xArr[i]);
                resultList.Add(yArr[i]);
            }

            return resultList.ToArray();
        }
    }
}
