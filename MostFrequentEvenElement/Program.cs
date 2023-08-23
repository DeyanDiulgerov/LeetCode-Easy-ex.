using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentEvenElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MostFrequentEvenElement(new int[] { 0, 1, 2, 2, 4, 4, 1 }));
            Console.WriteLine(MostFrequentEvenElement(new int[] { 4, 4, 4, 9, 2, 4 }));
            Console.WriteLine(MostFrequentEvenElement(new int[] { 29, 47, 21, 41, 13, 37, 25, 7 }));
        }

        public static int MostFrequentEvenElement(int[] nums)
        {
            var numAndCount = new Dictionary<int, int>();
            var allEvenNums = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!numAndCount.ContainsKey(nums[i]))
                    numAndCount.Add(nums[i], 1);
                else
                    numAndCount[nums[i]]++;
            }

            foreach (var kvp in numAndCount.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (kvp.Key % 2 == 0)
                    return kvp.Key;
            }

            return -1;
        }
    }
}
