using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountElementsWithMaximumFrequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountElementsWithMaximumFrequency(new int[] { 1, 2, 2, 3, 1, 4 }));
            Console.WriteLine(CountElementsWithMaximumFrequency(new int[] { 1, 2, 3, 4, 5 }));
        }
        public static int CountElementsWithMaximumFrequency(int[] nums)
        {
            var numAndFrequencyMap = new Dictionary<int, int>();
            int maxFreq = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!numAndFrequencyMap.ContainsKey(nums[i]))
                    numAndFrequencyMap.Add(nums[i], 1);
                else
                    numAndFrequencyMap[nums[i]]++;

                maxFreq = Math.Max(maxFreq, numAndFrequencyMap[nums[i]]);
            }

            int resultCount = 0;
            foreach (var kvp in numAndFrequencyMap.Where(x => x.Value == maxFreq))
            {
                resultCount += kvp.Value;
            }
            return resultCount;
        }
    }
}
