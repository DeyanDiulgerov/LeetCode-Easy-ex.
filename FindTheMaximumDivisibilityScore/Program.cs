using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheMaximumDivisibilityScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheMaximumDivisibilityScore(
                new int[] { 69, 3, 92, 14, 67, 90, 31, 40, 54, 63, 99, 88, 28, 100, 5, 72, 89, 60, 90, 71 },
                new int[] { 97, 16, 7, 60, 6, 57, 73, 84, 17, 8, 77, 60, 7, 74, 74, 24, 52, 43, 94, 48, 9, 99 }));
            Console.WriteLine(FindTheMaximumDivisibilityScore(new int[] { 4, 7, 9, 3, 9 }, new int[] { 5, 2, 3 }));
            Console.WriteLine(FindTheMaximumDivisibilityScore(new int[] { 20, 14, 21, 10 }, new int[] { 5, 7, 5 }));
            Console.WriteLine(FindTheMaximumDivisibilityScore(new int[] { 12 }, new int[] { 10, 16 }));
        }

        public static int FindTheMaximumDivisibilityScore(int[] nums, int[] divisors)
        {
            var divisorAndCount = new Dictionary<int, int>();

            for (int i = 0; i < divisors.Length; i++)
            {
                int counter = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] % divisors[i] == 0)
                        counter++;
                }

                if (!divisorAndCount.ContainsKey(divisors[i]))
                    divisorAndCount.Add(divisors[i], counter);
            }

            foreach (var kvp in divisorAndCount.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                return kvp.Key;
            }
            return -1;
        }
    }
}
