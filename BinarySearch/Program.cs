using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinarySearch(new int[] { -1, 0, 3, 5, 9, 12 }, 9));
            Console.WriteLine(BinarySearch(new int[] { -1, 0, 3, 5, 9, 12 }, 2));
        }

        public static int BinarySearch(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            while(left <= right)
            {
                int mid = left + (right - left) / 2;
                if(nums[mid] > target)
                    right = mid - 1;
                else if(nums[mid] < target)
                    left = mid + 1;
                else
                    return mid;
            }
            return -1;
        }
    }
}
