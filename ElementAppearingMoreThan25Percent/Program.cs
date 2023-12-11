using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementAppearingMoreThan25Percent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ElementAppearingMoreThan25Percent(new int[] { 1, 2, 2, 6, 6, 6, 6, 7, 10 }));
            Console.WriteLine(ElementAppearingMoreThan25Percent(new int[] { 1, 1 }));
        }
        // 2nd Way beats 96.61%
        public static int FindSpecialInteger(int[] arr)
        {
            double targetFreq = arr.Length * 0.25;
            var numAndFrequencyMap = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!numAndFrequencyMap.ContainsKey(arr[i]))
                    numAndFrequencyMap.Add(arr[i], 1);
                else
                    numAndFrequencyMap[arr[i]]++;

                if (numAndFrequencyMap[arr[i]] > targetFreq)
                    return arr[i];
            }
            return -1;
        }
        public static int ElementAppearingMoreThan25Percent(int[] arr)
        {
            var numAndAppeareance = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!numAndAppeareance.ContainsKey(arr[i]))
                    numAndAppeareance.Add(arr[i], 1);
                else
                    numAndAppeareance[arr[i]]++;
            }

            foreach (var kvp in numAndAppeareance.OrderByDescending(x => x.Value))
            {
                return kvp.Key;
            }

            return -1;
        }
    }
}
