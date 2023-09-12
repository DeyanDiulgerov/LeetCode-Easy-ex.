using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageValueOfEvenNumbersDivisibleByThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AverageValueOfEvenNumbersDivisibleByThree(new int[] { 4, 4, 9, 10 }));
            Console.WriteLine(AverageValueOfEvenNumbersDivisibleByThree(new int[] { 1, 3, 6, 10, 12, 15 }));
            Console.WriteLine(AverageValueOfEvenNumbersDivisibleByThree(new int[] { 1, 2, 4, 7, 10 }));
        }

        public static int AverageValueOfEvenNumbersDivisibleByThree(int[] nums)
        {
            var allNums = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 3 == 0 && nums[i] % 2 == 0)
                    allNums.Add(nums[i]);
            }

            if (allNums.Count() == 0)
                return 0;
            else
                return allNums.Sum() / allNums.Count();
        }
    }
}
