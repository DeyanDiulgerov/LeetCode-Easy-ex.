using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonWithLongestPushTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var events1 = new int[][]
            {
                new int[] {1,2},
                new int[] {2,5},
                new int[] {3,9},
                new int[] {1,15},
            };
            var events2 = new int[][]
            {
                new int[] {10,5},
                new int[] {1,7},
            };
            var events3 = new int[][]
           {
                new int[] {9,4},
                new int[] {19,5},
                new int[] {2,8},
                new int[] {3,11},
                new int[] {2,15},
           };
            var events4 = new int[][]
           {
                new int[] {13,11},
                new int[] {14,12},
                new int[] {8,16},
                new int[] {13,18},
                new int[] {20,19},
                new int[] {11,20},
           };
            Console.WriteLine(ButtonWithLongestPushTime(events4));
            Console.WriteLine(ButtonWithLongestPushTime(events3));
            Console.WriteLine(ButtonWithLongestPushTime(events1));
            Console.WriteLine(ButtonWithLongestPushTime(events2));
        }

        public static int ButtonWithLongestPushTime(int[][] events)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < events.Length; i++)
            {
                int button = events[i][0];
                int time = 0;
                if (i == 0)
                    time = events[i][1];
                else
                    time = events[i][1] - events[i - 1][1];
                if (!map.ContainsKey(button))
                    map.Add(button, time);
                else
                {
                    if (map[button] < time)
                        map[button] = time;
                }

            }
            return map
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .First()
                .Key;
        }
    }
}
