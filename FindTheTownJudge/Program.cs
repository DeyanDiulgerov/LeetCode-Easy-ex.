using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheTownJudge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheTownJudge(1, new int[][] { }));
            Console.WriteLine(FindTheTownJudge(2, new int[][] { }));
            Console.WriteLine(FindTheTownJudge(2, new int[][] { new int[] { 1, 2 } }));
            Console.WriteLine(FindTheTownJudge(3, new int[][] { new int[] { 1, 3 }, new int[] { 2, 3 } }));
            Console.WriteLine(FindTheTownJudge
                (3, new int[][] { new int[] { 1, 3 }, new int[] { 2, 3 }, new int[] { 3, 1 } }));
        }
        public static int FindTheTownJudge(int n, int[][] trust)
        {
            if (trust.Length == 0 && n == 1)
                return 1;
            else if (trust.Length == 0 && n == 2)
                return -1;

            var personAndTrusteesDict = new Dictionary<int, List<int>>();
            var trustsPeople = new List<int>();

            foreach (var item in trust)
            {
                trustsPeople.Add(item[0]);

                if (!personAndTrusteesDict.ContainsKey(item[1]))
                    personAndTrusteesDict.Add(item[1], new List<int>() { item[0] });
                else
                    personAndTrusteesDict[item[1]].Add(item[0]);
            }

            bool foundJudge = false;

            foreach (var kvp in personAndTrusteesDict)
            {
                if (!trustsPeople.Contains(kvp.Key))
                {
                    for (int i = 1; i <= n; i++)
                    {
                        if (i != kvp.Key && kvp.Value.Contains(i))
                            foundJudge = true;
                        if (i != kvp.Key && !kvp.Value.Contains(i))
                        {
                            foundJudge = false;
                            break;
                        }
                    }
                    if (foundJudge)
                        return kvp.Key;
                }
            }

            return -1;
        }
    }
}
