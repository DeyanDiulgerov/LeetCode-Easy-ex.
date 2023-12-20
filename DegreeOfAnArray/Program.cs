using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeOfAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DegreeOfAnArray(new int[] { 1, 2, 2, 3, 1 }));
            Console.WriteLine(DegreeOfAnArray(new int[] { 1, 2, 2, 3, 1, 4, 2 }));
        }

        public static int DegreeOfAnArray(int[] nums)
        {
            var numAndFrequencyMap = new Dictionary<int, int>();
            var allUsableDegrees = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!numAndFrequencyMap.ContainsKey(nums[i]))
                    numAndFrequencyMap.Add(nums[i], 1);
                else
                    numAndFrequencyMap[nums[i]]++;
            }
            int biggestDegree = 0;
            int count = 0;
            foreach (var kvp in numAndFrequencyMap.OrderByDescending(x => x.Value))
            {
                if (count == 0)
                    biggestDegree = kvp.Value;
                count++;

                if (kvp.Value == biggestDegree)
                    allUsableDegrees.Add(kvp.Key);
                else
                    break;
            }

            int min = int.MaxValue;
            for (int i = 0; i < allUsableDegrees.Count(); i++)
            {
                int ourNum = allUsableDegrees[i];
                int firstIndex = Array.IndexOf(nums, ourNum);
                int lastIndex = Array.LastIndexOf(nums, ourNum);
                int newMin = lastIndex - firstIndex + 1;
                min = Math.Min(min, newMin);
            }
            return min;
        }
    }
}
