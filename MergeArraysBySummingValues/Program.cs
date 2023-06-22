using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeArraysBySummingValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNums1 = new int[][]
            {
                new int[] {1,2},
                new int[] {2,3},
                new int[] {4,5},
            };

            var firstNums2 = new int[][]
            {
                new int[] {1,4},
                new int[] {3,2},
                new int[] {4,1},
            };


            var secondNums1 = new int[][]
            {
                new int[] {2,4},
                new int[] {3,6},
                new int[] {5,5},
            };

            var secondNums2 = new int[][]
            {
                new int[] {1,3},
                new int[] {4,3},
            };

            var input1 = MergeArraysBySummingValues(firstNums1, firstNums2);
            var input2 = MergeArraysBySummingValues(secondNums1, secondNums2);

            foreach (var item in input1)
            {
                Console.WriteLine(String.Join(",", item));
            }
            foreach (var item in input2)
            {
                Console.WriteLine(String.Join(",", item));
            }
        }

        public static int[][] MergeArraysBySummingValues(int[][] nums1, int[][] nums2)
        {
            var dictionary = new Dictionary<int, int>();

            foreach (var item in nums1)
                dictionary.Add(item[0], item[1]);

            foreach (var item in nums2)
            {
                if (!dictionary.ContainsKey(item[0]))
                    dictionary.Add(item[0], item[1]);
                else
                    dictionary[item[0]] += item[1];
            }

            var retArray = new List<int[]>();

            foreach (var item in dictionary.OrderBy(x => x.Key))
            {
                retArray.Add(new int[2] { item.Key, item.Value });
            }

            return retArray.ToArray();
        }
    }
}
