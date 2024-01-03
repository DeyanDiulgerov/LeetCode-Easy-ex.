using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveElement(new int[] { 3, 2, 2, 3 }, 3));
            Console.WriteLine(RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2));
            Console.WriteLine(RemoveElementTwoPointers(new int[] { 3, 2, 2, 3 }, 3));
            Console.WriteLine(RemoveElementTwoPointers(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2));
        }
        //Two pointers
        public static int RemoveElementTwoPointers(int[] nums, int val)
        {
            int left = 0, right = 0;

            while (right < nums.Length)
            {
                right = left + 1;
                while (left < nums.Length && nums[left] != val)
                    left++;
                while (right <= left || right < nums.Length && nums[right] == val)
                    right++;
                if (left >= right || right >= nums.Length)
                    break;

                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left++;
            }
            return nums.Count(x => x != val);
        }
        public static int RemoveElement(int[] nums, int val)
        {
            var index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }
            return index;
        }
    }
}
