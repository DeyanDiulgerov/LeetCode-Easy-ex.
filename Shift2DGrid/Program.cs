using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shift2DGrid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new int[][]
            {
                new int[] {1,2,3},
                new int[] {4,5,6},
                new int[] {7,8,9},
            };
            var grid2 = new int[][]
            {
                new int[] {3,8,1,9},
                new int[] {19,7,2,5},
                new int[] {4,6,11,10},
                new int[] {12,0,21,13},
            };
            var grid3 = new int[][]
            {
                new int[] {1,2,3},
                new int[] {4,5,6},
                new int[] {7,8,9},
            };
            foreach (var item in Shift2DGrid(grid1, 1))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in Shift2DGrid(grid2, 4))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in Shift2DGrid(grid3, 9))
                Console.WriteLine(String.Join(",", item));
        }
        public static IList<IList<int>> Shift2DGrid(int[][] grid, int k)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            var permMatrix = new int[m][];
            for (int i = 0; i < m; i++)
            {
                var newArr = new int[n];
                for (int j = 0; j < n; j++)
                    newArr[j] = grid[i][j];

                permMatrix[i] = newArr;
            }

            for (int i = 0; i < k; i++)
            {
                for (int row = 0; row < m; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (row == m - 1 && col == n - 1)
                            grid[0][0] = permMatrix[row][col];
                        else if (col == n - 1)
                            grid[row + 1][0] = permMatrix[row][col];
                        else
                            grid[row][col + 1] = permMatrix[row][col];
                    }
                }
                permMatrix = new int[m][];
                for (int p = 0; p < m; p++)
                {
                    var newArr = new int[n];
                    for (int j = 0; j < n; j++)
                        newArr[j] = grid[p][j];

                    permMatrix[p] = newArr;
                }
            }
            return grid;
        }
    }
}
