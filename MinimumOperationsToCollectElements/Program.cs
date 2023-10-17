using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumOperationsToCollectElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumOperationsToCollectElements(new List<int>() { 1, 1, 2, 2 }, 2));
            Console.WriteLine(MinimumOperationsToCollectElements(new List<int>() { 1, 2, 2 }, 2));
            Console.WriteLine(MinimumOperationsToCollectElements(new List<int>() { 3, 1, 5, 4, 2 }, 2));
            Console.WriteLine(MinimumOperationsToCollectElements(new List<int>() { 3, 1, 5, 4, 2 }, 5));
            Console.WriteLine(MinimumOperationsToCollectElements(new List<int>() { 3, 2, 5, 3, 1 }, 3));
        }

        public static int MinimumOperationsToCollectElements(IList<int> nums, int k)
        {
            int counter = 0;
            var allK = new List<int>();
            var allNums = new List<int>();

            for (int i = 1; i <= k; i++)
                allK.Add(i);

            for (int i = nums.Count() - 1; i >= 0; i--)
            {
                if (allK.Contains(nums[i]) && !allNums.Contains(nums[i]))
                    allNums.Add(nums[i]);

                counter++;
                allNums.Sort();

                if (allK.SequenceEqual(allNums))
                    return counter;
            }
            return counter;
        }
    }
}
