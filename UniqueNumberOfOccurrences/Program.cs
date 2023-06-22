using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueNumberOfOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UniqueNumberOfOccurrences(new int[] { 4, 0, 2, -5, -4 }));
            Console.WriteLine(UniqueNumberOfOccurrences(new int[] { 1, 2, 2, 1, 1, 3 }));
            Console.WriteLine(UniqueNumberOfOccurrences(new int[] { 1, 2 }));
            Console.WriteLine(UniqueNumberOfOccurrences(new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 }));
        }

        public static bool UniqueNumberOfOccurrences(int[] arr)
        {
            var numbersAndCount = new Dictionary<int, int>();
            var counterList = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!numbersAndCount.ContainsKey(arr[i]))
                    numbersAndCount.Add(arr[i], 1);
                else
                    numbersAndCount[arr[i]]++;
            }

            var testValue = 0;
            foreach (var kvp in numbersAndCount.OrderBy(x => x.Value))
            {
                if (kvp.Value == testValue)
                    return false;

                testValue = kvp.Value;
            }

            return true;
        }
    }
}
