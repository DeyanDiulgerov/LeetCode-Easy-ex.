using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", MoveZeroes(new int[] { 2, 1 })));
            Console.WriteLine(String.Join(",", MoveZeroes(new int[] { 4, 2, 4, 0, 0, 3, 0, 5, 1, 0 })));
            Console.WriteLine(String.Join(",", MoveZeroes(new int[] { 0, 0 })));
            Console.WriteLine(String.Join(",", MoveZeroes(new int[] { 0, 1, 0, 3, 12 })));
            Console.WriteLine(String.Join(",", MoveZeroes(new int[] { 0 })));
        }

      //public static void MoveZeroes(int[] nums)
        public static int[] MoveZeroes(int[] nums)
        {
            int left = 0, right = 1;
            while (right < nums.Length)
            {
                // While nums[left] != 0, nums[right] == 0;
                while (left < nums.Length && nums[left] != 0)
                    left++;
                while (right <= left || (right < nums.Length && nums[right] == 0))
                    right++;
                if (right >= nums.Length)
                    break;

                var temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left++;
                right++;
            }
            return nums;
        }
    }
}
