using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountHillsAndValleysInAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountHillsAndValleysInAnArray(new int[] { 2, 4, 1, 1, 6, 5 }));
            Console.WriteLine(CountHillsAndValleysInAnArray(new int[] { 6, 6, 5, 5, 4, 1 }));
        }

        public static int CountHillsAndValleysInAnArray(int[] nums)
        {
            int counter = 0;
            var usedIndices = new List<int>();

            for (int i = 1; i < nums.Length - 1; i++)
            {
                int left = i - 1;
                int right = i + 1;

                while (nums[i] == nums[left] && left > 0)
                    left--;
                while (nums[i] == nums[right] && right < nums.Length - 1)
                    right++;

                if (usedIndices.Contains(i - 1) && nums[i] == nums[i - 1])
                {
                    usedIndices.Add(i);
                    continue;
                }

                if (nums[i] > nums[right] && nums[i] > nums[left]
                 || nums[i] < nums[right] && nums[i] < nums[left])
                {
                    counter++;
                    usedIndices.Add(i);
                }
            }

            return counter;
        }
    }
}
