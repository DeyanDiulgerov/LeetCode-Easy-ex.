using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetMismatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SetMismatch(new int[] { 1, 2, 2, 4 })));
            Console.WriteLine(String.Join(",", SetMismatch(new int[] { 1, 1 })));
        }

        public static int[] SetMismatch(int[] nums)
        {
            int n = nums.Length;
            var result = new int[2];
            var numAndCountMap = new Dictionary<int, int>();

            for (int i = 1; i <= n; i++)
                numAndCountMap.Add(i, 0);

            for (int i = 0; i < nums.Length; i++)
                numAndCountMap[nums[i]]++;

            foreach (var kvp in numAndCountMap)
            {
                if (kvp.Value == 2)
                    result[0] = kvp.Key;
                if (kvp.Value == 0)
                    result[1] = kvp.Key;
            }

            return result;
        }
    }
}
