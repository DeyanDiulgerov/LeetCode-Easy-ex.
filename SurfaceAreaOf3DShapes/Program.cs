using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceAreaOf3DShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new int[][]
            {
                new int[] {1,2},
                new int[] {3,4}
            };
            var grid2 = new int[][]
            {
                new int[] {1,1,1},
                new int[] {1,0,1},
                new int[] {1,1,1},
            };
            var grid3 = new int[][]
            {
                new int[] {2,2,2},
                new int[] {2,1,2},
                new int[] {2,2,2},
            };
            Console.WriteLine(SurfaceAreaOf3DShapes(grid1));
            Console.WriteLine(SurfaceAreaOf3DShapes(grid2));
            Console.WriteLine(SurfaceAreaOf3DShapes(grid3));
        }
        public static int SurfaceAreaOf3DShapes(int[][] grid)
        {
            int n = grid.Length;
            int totalCount = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int borderCount = CheckBoundsOfMatrix(grid, row, col, n);
                    int neighbourValueCount = CheckNeighboursValue(grid, row, col, n);
                    totalCount += borderCount;
                    totalCount += neighbourValueCount;

                    if (grid[row][col] != 0)
                        totalCount += 2;
                }
            }
            return totalCount;
        }
        public static int CheckNeighboursValue(int[][] grid, int row, int col, int n)
        {
            int count = 0;

            if (row + 1 < n && grid[row + 1][col] > grid[row][col])
                count += grid[row + 1][col] - grid[row][col];
            if (col + 1 < n && grid[row][col + 1] > grid[row][col])
                count += grid[row][col + 1] - grid[row][col];
            if (row - 1 >= 0 && grid[row - 1][col] > grid[row][col])
                count += grid[row - 1][col] - grid[row][col];
            if (col - 1 >= 0 && grid[row][col - 1] > grid[row][col])
                count += grid[row][col - 1] - grid[row][col];

            return count;
        }
        public static int CheckBoundsOfMatrix(int[][] grid, int row, int col, int n)
        {
            int count = 0;

            if (row - 1 < 0)
                count += grid[row][col];
            if (col - 1 < 0)
                count += grid[row][col];
            if (row + 1 >= n)
                count += grid[row][col];
            if (col + 1 >= n)
                count += grid[row][col];

            return count;
        }
    }
}
