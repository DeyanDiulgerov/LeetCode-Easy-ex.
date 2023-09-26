using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumRightShiftsToSortTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumRightShiftsToSortTheArray(new List<int>() { 3, 4, 5, 1, 2 }));
            Console.WriteLine(MinimumRightShiftsToSortTheArray(new List<int>() { 1, 3, 5 }));
            Console.WriteLine(MinimumRightShiftsToSortTheArray(new List<int>() { 2, 1, 4 }));
        }
        public static int MinimumRightShiftsToSortTheArray(IList<int> nums)
        {
            var sorted = new List<int>(nums);
            sorted.Sort();

            if (nums == sorted)
                return 0;

            var testList = new List<int>(nums);

            int counter = 0;
            while (!testList.SequenceEqual(sorted) && counter < nums.Count())
            {
                Console.WriteLine(String.Join(",", testList));
                Console.WriteLine(String.Join(",", sorted));
                var ourNum = testList.Last();
                testList.Remove(ourNum);
                testList.Insert(0, ourNum);

                counter++;
            }

            if (counter >= nums.Count())
                return -1;
            else
                return counter;
        }
    }
}
