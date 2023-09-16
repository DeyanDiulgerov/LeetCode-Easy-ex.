using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumPopulationYear
{
    class Program
    {
        static void Main(string[] args)
        {
            var logs1 = new int[][]
            {
                new int[] {1993,1999},
                new int[] {2000,2010}
            };
            var logs2 = new int[][]
           {
                new int[] {1950,1961},
                new int[] { 1960, 1971 },
                new int[] { 1970, 1981 }
           };

            Console.WriteLine(MaximumPopulationYear(logs1));
            Console.WriteLine(MaximumPopulationYear(logs2));
        }

        public static int MaximumPopulationYear(int[][] logs)
        {
            var yearAndCountDict = new Dictionary<int, int>();

            foreach (var item in logs)
            {
                for (int i = item[0]; i < item[1]; i++)
                {
                    if (!yearAndCountDict.ContainsKey(i))
                        yearAndCountDict.Add(i, 1);
                    else
                        yearAndCountDict[i]++;
                }
            }

            foreach (var kvp in yearAndCountDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                return kvp.Key;

            return -1;
        }
    }
}
