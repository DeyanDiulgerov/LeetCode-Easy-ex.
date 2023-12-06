using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumDifferenceBetweenHighestAndLowestOfKScores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumDifferenceBetweenHighestAndLowestOfKScores(new int[] { 90 }, 1));
            Console.WriteLine(MinimumDifferenceBetweenHighestAndLowestOfKScores(new int[] { 9, 4, 1, 7 }, 2));
        }

        public static int MinimumDifferenceBetweenHighestAndLowestOfKScores(int[] nums, int k)
        {
            Array.Sort(nums);
            var min = 0;

            var newList = new List<int>();
            for (int i = 0; i < k; i++)
                newList.Add(nums[i]);

            min = newList.Last() - newList.First();
            for (int i = k; i < nums.Length; i++)
            {
                newList.RemoveAt(0);
                newList.Add(nums[i]);

                var newMin = newList.Last() - newList.First();
                min = Math.Min(min, newMin);
            }
            return min;
        }
    }
}
