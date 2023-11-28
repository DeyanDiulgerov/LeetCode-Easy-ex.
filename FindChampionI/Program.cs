using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindChampionI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new int[][]
            {
                new int[] {0,1},
                new int[] {0,0},
            };
            var grid2 = new int[][]
            {
                new int[] {0,0,1},
                new int[] {1,0,1},
                new int[] {0,0,0},
            };
            Console.WriteLine(FindChampionI(grid1));
            Console.WriteLine(FindChampionI(grid2));
        }
        public static int FindChampionI(int[][] grid)
        {
            int n = grid.Length;
            var potentialChampions = new List<int>();
            for (int i = 0; i < n; i++)
                potentialChampions.Add(i);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1 && potentialChampions.Contains(j))
                        potentialChampions.Remove(j);
                }
            }
            return potentialChampions[0];
        }
    }
}
