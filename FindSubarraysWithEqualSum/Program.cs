using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSubarraysWithEqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindSubarraysWithEqualSum(new int[] { 4, 2, 4 }));
            Console.WriteLine(FindSubarraysWithEqualSum(new int[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine(FindSubarraysWithEqualSum(new int[] { 0, 0, 0 }));
        }

        public static bool FindSubarraysWithEqualSum(int[] nums)
        {
            var allSums = new List<int>();
            //var sumAndIndexes = new Dictionary<int, List<int>>();
            var resultList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    allSums.Add(nums[i] + nums[j]);
                    i++;
                }
            }

            foreach (var item in allSums)
            {
                if (resultList.Contains(item))
                    return true;

                resultList.Add(item);
            }

            return false;
        }
    }
}
