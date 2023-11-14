using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubarraysDistinctElementSumOfSquaresI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SubarraysDistinctElementSumOfSquaresI(new List<int>() { 1, 2, 1 })));
            Console.WriteLine(String.Join(",", SubarraysDistinctElementSumOfSquaresI(new List<int>() { 1, 1 })));
        }

        public static int SubarraysDistinctElementSumOfSquaresI(List<int> nums)
        {
            var sum = nums.Count();

            for (int i = 0; i < nums.Count(); i++)
            {
                var newList = new List<int>() { nums[i] };
                for (int j = i + 1; j < nums.Count(); j++)
                {
                    newList.Add(nums[j]);
                    var count = newList.Distinct().Count();
                    count *= count;
                    sum += count;
                }
            }
            return sum;
        }
    }
}
