using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEmployeeThatWorkedOnTheLongestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logs1 = new int[][]
            {
                new int[] {0,3},
                new int[] {2,5},
                new int[] {0,9},
                new int[] {1,15},
            };
            var logs2 = new int[][]
            {
                new int[] {1,1},
                new int[] {3,7},
                new int[] {2,12},
                new int[] {7,17},
            };
            var logs3 = new int[][]
            {
                new int[] {0,10},
                new int[] {1,20},
            };

            Console.WriteLine(TheEmployeeThatWorkedOnTheLongestTask(10, logs1));
            Console.WriteLine(TheEmployeeThatWorkedOnTheLongestTask(26, logs2));
            Console.WriteLine(TheEmployeeThatWorkedOnTheLongestTask(2, logs3));
        }

        public static int TheEmployeeThatWorkedOnTheLongestTask(int n, int[][] logs)
        {
            var workerAndTimeDict = new Dictionary<int, int>();

            for (int i = 0; i < logs.Length; i++)
            {
                if (i == 0)
                {
                    if (!workerAndTimeDict.ContainsKey(logs[i][0]))
                        workerAndTimeDict.Add(logs[i][0], logs[i][1]);
                }
                else
                {
                    var time = logs[i][1] - logs[i - 1][1];

                    if (!workerAndTimeDict.ContainsKey(logs[i][0]))
                        workerAndTimeDict.Add(logs[i][0], time);
                    else
                    {
                        if (workerAndTimeDict[logs[i][0]] < time)
                            workerAndTimeDict[logs[i][0]] = time;
                    }
                }
            }

            foreach (var kvp in workerAndTimeDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                return kvp.Key;
            }

            return -1;
        }
    }
}
