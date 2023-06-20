using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetIndices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", TargetIndices(new int[] { 1, 2, 5, 2, 3 }, 2)));
            Console.WriteLine(String.Join(",", TargetIndices(new int[] { 1, 2, 5, 2, 3 }, 3)));
            Console.WriteLine(String.Join(",", TargetIndices(new int[] { 1, 2, 5, 2, 3 }, 5)));
        }

        public static IList<int> TargetIndices(int[] nums, int target)
        {
            var sortedNums = new List<int>(nums);
            sortedNums.Sort();

            var indexList = new List<int>();

            for (int i = 0; i < sortedNums.Count(); i++)
            {
                if (sortedNums[i] == target)
                {
                    indexList.Add(i);
                }
            }

            return indexList.ToArray();
        }
    }
}
