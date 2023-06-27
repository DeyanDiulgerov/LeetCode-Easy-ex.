using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencySort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FrequencySort(new int[] { 1, 1, 2, 2, 2, 3 })));
            Console.WriteLine(String.Join(",", FrequencySort(new int[] { 2, 3, 1, 3, 2 })));
            Console.WriteLine(String.Join(",", FrequencySort(new int[] { -1, 1, -6, 4, 5, -6, 1, 4, 1 })));
        }

        public static int[] FrequencySort(int[] nums)
        {
            var numAndCountDiction = new Dictionary<int, int>();
            var resultList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!numAndCountDiction.ContainsKey(nums[i]))
                    numAndCountDiction.Add(nums[i], 1);
                else
                    numAndCountDiction[nums[i]]++;
            }

            foreach (var kvp in numAndCountDiction.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                for (int i = 0; i < kvp.Value; i++)
                {
                    resultList.Add(kvp.Key);
                }
            }

            return resultList.ToArray();
        }
    }
}
