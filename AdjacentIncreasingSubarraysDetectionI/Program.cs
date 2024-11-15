using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentIncreasingSubarraysDetectionI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AdjacentIncreasingSubarraysDetectionI(
                new List<int>() { 2, 5, 7, 8, 9, 2, 3, 4, 3, 1 }, 3));
            Console.WriteLine(AdjacentIncreasingSubarraysDetectionI(
                new List<int>() { 1, 2, 3, 4, 4, 4, 4, 5, 6, 7 }, 5));
        }

        public static bool AdjacentIncreasingSubarraysDetectionI(IList<int> nums, int k)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                bool shouldStop = false;
                int b = i + k;
                for (int j = i + 1; j < Math.Min(b, nums.Count); j++)
                {
                    if (nums[j] <= nums[j - 1])
                    {
                        shouldStop = true;
                        break;
                    }
                }
                if (shouldStop)
                    continue;
                if (nums.Count - b < k)
                    break;
                for (int j = b + 1; j < Math.Min(b + k, nums.Count); j++)
                {
                    if (nums[j] <= nums[j - 1])
                    {
                        shouldStop = true;
                        break;
                    }
                }
                if (!shouldStop)
                    return true;
            }
            return false;
        }
    }
}
