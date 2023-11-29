using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostVisitedSectorInACircularTrack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", MostVisitedSectorInACircularTrack(4, new int[] { 1, 3, 1, 2 })));
            Console.WriteLine(String.Join(",", MostVisitedSectorInACircularTrack(2, new int[] { 2, 1, 2, 1, 2, 1, 2, 1, 2 })));
            Console.WriteLine(String.Join(",", MostVisitedSectorInACircularTrack(7, new int[] { 1, 3, 5, 7 })));
        }
        public static IList<int> MostVisitedSectorInACircularTrack(int n, int[] rounds)
        {
            int m = rounds.Length;
            var sectorAndVisitsMap = new Dictionary<int, int>();
            var resultList = new List<int>();

            for (int i = 1; i <= n; i++)
                sectorAndVisitsMap.Add(i, 0);

            for (int i = 0; i < m - 1; i++)
            {
                /*foreach (var item in sectorAndVisitsMap)
                    Console.WriteLine(item);*/
                if (i == 0)
                {
                    var curr = rounds[i];
                    while (curr > rounds[i + 1])
                    {
                        sectorAndVisitsMap[curr]++;
                        if (curr == n)
                        {
                            curr = 1;
                            break;
                        }

                        curr++;
                    }
                    for (int r = curr; r <= rounds[i + 1]; r++)
                        sectorAndVisitsMap[r]++;
                }
                else
                {
                    var curr = rounds[i] + 1;
                    if (curr == n)
                    {
                        sectorAndVisitsMap[curr]++;
                        curr = 1;
                    }
                    if (curr > n)
                        curr = 1;
                    while (curr > rounds[i + 1])
                    {
                        sectorAndVisitsMap[curr]++;
                        if (curr == n)
                        {
                            curr = 1;
                            break;
                        }

                        curr++;
                    }
                    for (int r = curr; r <= rounds[i + 1]; r++)
                        sectorAndVisitsMap[r]++;
                }
            }
            var max = 0;
            foreach (var item in sectorAndVisitsMap)
                Console.WriteLine(item);

            foreach (var kvp in sectorAndVisitsMap.OrderByDescending(x => x.Value))
            {
                if (kvp.Value >= max)
                {
                    max = kvp.Value;
                    resultList.Add(kvp.Key);
                }
            }
            return resultList;
        }
    }
}
