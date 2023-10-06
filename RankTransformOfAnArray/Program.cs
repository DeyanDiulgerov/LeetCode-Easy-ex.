using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankTransformOfAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", RankTransformOfAnArray(new int[] { 37, 12, 28, 9, 100, 56, 80, 5, 12 })));
            Console.WriteLine(String.Join(",", RankTransformOfAnArray(new int[] { 40, 10, 20, 30 })));
            Console.WriteLine(String.Join(",", RankTransformOfAnArray(new int[] { 100, 100, 100 })));
        }
        public static int[] RankTransformOfAnArray(int[] arr)
        {
            var numAndRankDict = new Dictionary<int, int>();
            var sorted = new List<int>(arr);
            sorted.Sort();

            int counter = 1;

            for (int i = 0; i < sorted.Count(); i++)
            {
                if (!numAndRankDict.ContainsKey(sorted[i]))
                {
                    numAndRankDict.Add(sorted[i], counter);
                    counter++;
                }
            }

            var resultArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
                resultArr[i] = numAndRankDict[arr[i]];

            return resultArr;
        }
    }
}
