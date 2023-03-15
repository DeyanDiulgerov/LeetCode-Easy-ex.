
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