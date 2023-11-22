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
            int n = nums.Length;
            int l = 0, r = n;
            while (l < r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] < target)
                    l = mid + 1;
                else if (nums[mid] > target)
                    r = mid;
                else
                    return mid;
            }
            return -1;
        }
    }
}
