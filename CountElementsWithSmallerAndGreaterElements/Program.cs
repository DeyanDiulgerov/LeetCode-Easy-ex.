using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountElementsWithSmallerAndGreaterElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountElementsWithSmallerAndGreaterElements(new int[] { 11, 7, 2, 15 }));
            Console.WriteLine(CountElementsWithSmallerAndGreaterElements(new int[] { -3, 3, 3, 90 }));
        }

        public static int CountElementsWithSmallerAndGreaterElements(int[] nums)
        {
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Any(x => x > nums[i]) && nums.Any(x => x < nums[i]))
                    counter++;
            }

            return counter;
        }
    }
}
