using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfGridSatisfiesConditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new int[][]
            {
                new int[] {1,0,2},
                new int[] {1,0,2},
            };
            var grid2 = new int[][]
            {
                new int[] {1},
                new int[] {2},
                new int[] {3},
            };
            Console.WriteLine(CheckIfGridSatisfiesConditions(grid1));
            Console.WriteLine(CheckIfGridSatisfiesConditions(grid2));
        }
        public static bool CheckIfGridSatisfiesConditions(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            for (int row = 0; row < m; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row != m - 1 && grid[row][col] != grid[row + 1][col])
                        return false;
                    if (col != n - 1 && grid[row][col] == grid[row][col + 1])
                        return false;
                }
            }
            return true;
        }
    }
}
