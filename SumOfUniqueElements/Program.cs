using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfUniqueElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfUniqueElements(new int[] { 1, 2, 3, 2 }));
            Console.WriteLine(SumOfUniqueElements(new int[] { 1, 1, 1, 1, 1 }));
            Console.WriteLine(SumOfUniqueElements(new int[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine(SumOfUniqueElements(new int[] { 10, 6, 9, 6, 9, 6, 8, 7 }));
            Console.WriteLine(SumOfUniqueElements(new int[] { 10 }));
        }

        public static int SumOfUniqueElements(int[] nums)
        {
            if (nums.Count() == 1)
                return nums.First();
            else if (nums.All(x => x == nums.First()))
                return 0;

            var testList = new List<int>();
            var unusableNums = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!testList.Contains(nums[i]) && !unusableNums.Contains(nums[i]))
                    testList.Add(nums[i]);
                else
                {
                    testList.Remove(nums[i]);
                    unusableNums.Add(nums[i]);
                }
            }

            return testList.Sum();
        }
    }
}
