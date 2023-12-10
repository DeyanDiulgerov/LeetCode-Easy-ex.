
using System.Linq;

namespace RemoveDuplicatesFromSortedArray
{
    class Program
    {
        //Given an integer x, return true if x is a palindrome, and false otherwise.

        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            RemoveDuplicates(nums);

        }
        // My Way - Two Pointers
        public static int RemoveDuplicates(int[] nums)
        {
            int left = 0, right = 0;
            int indexCount = 0;
            int distinctCount = nums.Distinct().Count();

            while (left < nums.Length - 1)
            {
                left = right;

                while (right < nums.Length - 1 && nums[left] == nums[right])
                    right++;

                nums[indexCount] = nums[left];
                indexCount++;

                if (indexCount >= distinctCount)
                    break;
            }
            return nums.Take(distinctCount).Count();
        }
        // NOT mine - Leetcode solution
        public static int RemoveDuplicates(int[] nums)
        {
            var count = (nums.Length == 0 ? 0 : 1);

            foreach (var num in nums)
                if (nums[count - 1] < num)
                    nums[count++] = num;

            Console.WriteLine(count);
            Console.WriteLine($"nums = {String.Join(",", nums)}");
            return count;
        }
    }
}
