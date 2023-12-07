using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLargestGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountLargestGroup(13));
            Console.WriteLine(CountLargestGroup(2));
        }

        public static int CountLargestGroup(int n)
        {
            int resultCount = 0;
            var numAndGroupMap = new Dictionary<int, List<int>>();
            for (int i = 1; i <= n; i++)
            {
                var str = i.ToString();
                int sum = 0;
                for (int j = 0; j < str.Length; j++)
                    sum += int.Parse(str[j].ToString());

                if (!numAndGroupMap.ContainsKey(sum))
                    numAndGroupMap.Add(sum, new List<int>() { sum });
                else
                    numAndGroupMap[sum].Add(i);
            }
            numAndGroupMap = numAndGroupMap
                .OrderByDescending(x => x.Value.Count())
                .ToDictionary(x => x.Key, x => x.Value);

            var biggest = numAndGroupMap.Values.First().Count();

            foreach (var kvp in numAndGroupMap.OrderByDescending(x => x.Value.Count()))
                if (kvp.Value.Count() == biggest)
                    resultCount++;

            return resultCount;
        }
    }
}
