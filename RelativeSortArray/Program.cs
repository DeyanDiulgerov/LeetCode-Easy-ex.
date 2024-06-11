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
            var res = new List<int>();
            var list1 = new List<int>(arr1);
            var leftOutNums = new List<int>();
            var map = new Dictionary<int, int>();
            for(int i = 0; i < list1.Count; i++)
            {
                if(!arr2.Contains(list1[i]))
                {
                    leftOutNums.Add(list1[i]);
                    continue;
                }
                if(!map.ContainsKey(list1[i]))
                    map.Add(list1[i], 1);
                else
                    map[list1[i]]++;
            }
            leftOutNums.Sort();
            foreach(int num in arr2)
            {
                for(int i = 0; i < map[num]; i++)
                    res.Add(num);
            }
            res.AddRange(leftOutNums);
            return res.ToArray();
        }
    }
}
