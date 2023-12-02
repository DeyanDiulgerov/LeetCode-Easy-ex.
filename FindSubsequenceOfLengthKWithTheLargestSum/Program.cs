using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSubsequenceOfLengthKWithTheLargestSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",",
                FindSubsequenceOfLengthKWithTheLargestSum(new int[] { 2, 1, 3, 3 }, 2)));
            Console.WriteLine(String.Join(",", 
                FindSubsequenceOfLengthKWithTheLargestSum(new int[] { -1, -2, 3, 4 }, 3)));
            Console.WriteLine(String.Join(",", 
                FindSubsequenceOfLengthKWithTheLargestSum(new int[] { 3, 4, 3, 3 }, 2)));
        }
        public static int[] FindSubsequenceOfLengthKWithTheLargestSum(int[] nums, int k)
        {
            var indexAndNumMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
                indexAndNumMap.Add(i, nums[i]);

            var sortedByAscDict = indexAndNumMap.OrderByDescending(x => x.Value);
            var dictWithKLenght = new Dictionary<int, int>();

            foreach (var item in sortedByAscDict)
            {
                if (k == 0)
                    break;

                dictWithKLenght.Add(item.Key, item.Value);
                k--;
            }

            var resultDict = dictWithKLenght.OrderBy(x => x.Key);
            var resultArr = new int[resultDict.Count()];

            for (int i = 0; i < resultArr.Length; i++)
                resultArr[i] = resultDict.ElementAt(i).Value;

            return resultArr;
        }
    }
}
