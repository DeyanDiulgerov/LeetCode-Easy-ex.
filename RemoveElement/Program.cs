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
