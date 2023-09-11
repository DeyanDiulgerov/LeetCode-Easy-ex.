using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPairsWhoseSumIsLessThanTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountPairsWhoseSumIsLessThanTarget(new List<int>() { -1, 1, 2, 3, 1 }, 2));
            Console.WriteLine(CountPairsWhoseSumIsLessThanTarget(new List<int>() { -6, 2, 5, -2, -7, -1, 3 }, -2));
        }

        public static int CountPairsWhoseSumIsLessThanTarget(IList<int> nums, int target)
        {
            int counter = 0;

            for (int i = 0; i < nums.Count(); i++)
            {
                for (int j = i + 1; j < nums.Count(); j++)
                {
                    if (nums[i] + nums[j] < target)
                        counter++;
                }
            }
            return counter;
        }
    }
}
