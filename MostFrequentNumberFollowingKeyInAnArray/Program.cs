using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumberFollowingKeyInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MostFrequentNumberFollowingKeyInAnArray(new int[] { 11, 22, 11, 33, 11, 33 }, 11));
            Console.WriteLine(MostFrequentNumberFollowingKeyInAnArray(new int[] { 1, 100, 200, 1, 100 }, 1));
            Console.WriteLine(MostFrequentNumberFollowingKeyInAnArray(new int[] { 2, 2, 2, 2, 3 }, 2));
        }

        public static int MostFrequentNumberFollowingKeyInAnArray(int[] nums, int key)
        {
            var targetAndCountDict = new Dictionary<int, int>();

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] == key)
                {
                    if (!targetAndCountDict.ContainsKey(nums[i]))
                        targetAndCountDict.Add(nums[i], 1);
                    else
                        targetAndCountDict[nums[i]]++;
                }
            }

            foreach (var kvp in targetAndCountDict.OrderByDescending(x => x.Value))
            {
                return kvp.Key;
            }

            return -1;
        }
    }
}
