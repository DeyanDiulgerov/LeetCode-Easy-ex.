using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllKDistantIndices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FindAllKDistantIndices(
                new int[] { 3, 4, 9, 1, 3, 9, 5 }, 9, 1)));

            Console.WriteLine(String.Join(",", FindAllKDistantIndices(
                new int[] { 2, 2, 2, 2, 2 }, 2, 2)));
        }

        public static IList<int> FindAllKDistantIndices(int[] nums, int key, int k)
        {
            var resultList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (Math.Abs(i - j) <= k && nums[j] == key)
                    {
                        resultList.Add(i);
                        break;
                    }
                }
            }

            return resultList;
        }
    }
}
