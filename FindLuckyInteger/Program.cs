using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLuckyInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindLuckyInteger(new int[] { 2, 2, 3, 4 }));
            Console.WriteLine(FindLuckyInteger(new int[] { 1, 2, 2, 3, 3, 3 }));
            Console.WriteLine(FindLuckyInteger(new int[] { 2, 2, 2, 3, 3 }));
        }

        public static int FindLuckyInteger(int[] arr)
        {
            var numAndFrequency = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!numAndFrequency.ContainsKey(arr[i]))
                    numAndFrequency.Add(arr[i], 1);
                else
                    numAndFrequency[arr[i]]++;
            }

            foreach (var kvp in numAndFrequency.OrderByDescending(x => x.Value))
            {
                if (kvp.Key == kvp.Value)
                    return kvp.Key;
            }

            return -1;
        }
    }
}
