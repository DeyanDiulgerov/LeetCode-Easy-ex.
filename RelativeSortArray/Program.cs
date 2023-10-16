using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativeSortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", RelativeSortArray
                (new int[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 }, new int[] { 2, 1, 4, 3, 9, 6 })));
            Console.WriteLine(String.Join(",", RelativeSortArray
                 (new int[] { 28, 6, 22, 8, 44, 17 }, new int[] { 22, 28, 8, 6 })));
        }

        public static int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            var result = new List<int>();

            for (int i = 0; i < arr2.Length; i++)
            {
                var numCount = arr1.Count(x => x == arr2[i]);

                for (int j = 0; j < numCount; j++)
                    result.Add(arr2[i]);
            }
            var lastNums = new List<int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                if (!result.Contains(arr1[i]))
                    lastNums.Add(arr1[i]);
            }

            lastNums.Sort();

            for (int i = 0; i < lastNums.Count(); i++)
                result.Add(lastNums[i]);

            return result.ToArray();
        }
    }
}
