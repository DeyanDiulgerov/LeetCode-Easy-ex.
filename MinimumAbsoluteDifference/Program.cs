using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumAbsoluteDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var input5 = MinimumAbsoluteDifference(new int[] { -10, 23 });
            var input4 = MinimumAbsoluteDifference(new int[] { 40, 11, 26, 27, -20 });
            var input1 = MinimumAbsoluteDifference(new int[] { 4, 2, 1, 3 });
            var input2 = MinimumAbsoluteDifference(new int[] { 1, 3, 6, 10, 15 });
            var input3 = MinimumAbsoluteDifference(new int[] { 3, 8, -10, 23, 19, -4, -14, 27 });


            foreach (var item in input5)
                Console.WriteLine(String.Join(",", item));
            foreach (var item in input4)
                Console.WriteLine(String.Join(",", item));
            foreach (var item in input1)
                Console.WriteLine(String.Join(",", item));
            foreach (var item in input2)
                Console.WriteLine(String.Join(",", item));
            foreach (var item in input3)
                Console.WriteLine(String.Join(",", item));
        }

        public static IList<IList<int>> MinimumAbsoluteDifference(int[] arr)
        {
            if (arr.Length == 2)
                return new List<IList<int>>() { new List<int>() { arr.First(), arr.Last() } };

            var listedArr = new List<int>(arr);
            listedArr.Sort();

            var resultList = new List<IList<int>>();

            var absoluteMin = listedArr.Last();

            for (int i = 0; i < listedArr.Count(); i++)
            {
                if (i < listedArr.Count() - 1 && listedArr[i + 1] - listedArr[i] < absoluteMin)
                    absoluteMin = listedArr[i + 1] - listedArr[i];
            }

            for (int i = 0; i < listedArr.Count(); i++)
            {
                if (i < listedArr.Count() - 1 && listedArr[i + 1] - listedArr[i] == absoluteMin)
                    resultList.Add(new List<int>() { listedArr[i], listedArr[i + 1] });
            }

            return resultList;
        }
    }
}
