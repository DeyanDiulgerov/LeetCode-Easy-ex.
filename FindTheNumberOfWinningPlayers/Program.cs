using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheNumberOfWinningPlayers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] pick1 = new int[][]
            {
                new int[] {0, 0},
                new int[] {1, 0},
                new int[] {1, 0},
                new int[] {2, 1},
                new int[] {2, 1},
                new int[] {2, 0},
            };
            int[][] pick2 = new int[][]
            {
                new int[] {1,1},
                new int[] {1,2},
                new int[] {1,3},
                new int[] {1,4},
                new int[] {2, 1},
                new int[] {2, 0},
            };
            int[][] pick3 = new int[][]
            {
                new int[] {1,1},
                new int[] {2,4},
                new int[] {2,4},
                new int[] {2,4},
            };
            Console.WriteLine(FindTheNumberOfWinningPlayers(4, pick1));
            Console.WriteLine(FindTheNumberOfWinningPlayers(4, pick2));
            Console.WriteLine(FindTheNumberOfWinningPlayers(4, pick3));
        }

        public static int FindTheNumberOfWinningPlayers(int n, int[][] pick)
        {
            var mapPlayerBallCount = new Dictionary<int, Dictionary<int, int>>();
            foreach (var p in pick)
            {
                int player = p[0];
                int ballColor = p[1];
                if (!mapPlayerBallCount.ContainsKey(player))
                {
                    var mapColorCount = new Dictionary<int, int>()
                    {
                        {ballColor, 1},
                    };
                    mapPlayerBallCount.Add(player, mapColorCount);
                }
                else
                {
                    if (!mapPlayerBallCount[player].ContainsKey(ballColor))
                        mapPlayerBallCount[player].Add(ballColor, 1);
                    else
                        mapPlayerBallCount[player][ballColor]++;
                }
            }
            foreach (var player in mapPlayerBallCount)
            {
                Console.WriteLine($"Player: {player.Key} has:");
                foreach (var item in mapPlayerBallCount[player.Key])
                {
                    Console.WriteLine($"Ball Color: {item.Key} with {item.Value} count");
                }
            }
            Console.WriteLine("==============================================================");
            Console.WriteLine("==============================================================");
            int resCount = 0;
            foreach (var kvp in mapPlayerBallCount)
            {
                int player = kvp.Key;
                if (kvp.Value.Any(x => x.Value > player))
                    resCount++;
            }
            return resCount;
        }
    }
}
