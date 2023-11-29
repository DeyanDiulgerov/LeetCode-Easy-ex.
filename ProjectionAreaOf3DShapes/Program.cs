using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectionAreaOf3DShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new int[][]
            {
                new int[] {1,2},
                new int[] {3,4 }
            };
            var grid2 = new int[][]
            {
                new int[] {2},
            };
            var grid3 = new int[][]
            {
                new int[] {1,0},
                new int[] {0,2}
            };
            Console.WriteLine(ProjectionAreaOf3DShapes(grid1));
            Console.WriteLine(ProjectionAreaOf3DShapes(grid2));
            Console.WriteLine(ProjectionAreaOf3DShapes(grid3));
        }
        public static int ProjectionAreaOf3DShapes(int[][] grid)
        {
            var sum = 0;
            int n = grid.Length;
            int max = 0;

            for (int row = 0; row < n; row++)
                for (int col = 0; col < n; col++)
                    if (grid[row][col] > 0)
                        sum += 1;

            for (int row = 0; row < n; row++)
            {
                max = 0;

                for (int col = 0; col < n; col++)
                {
                    if (max < grid[row][col])
                        max = grid[row][col];
                }
                sum += max;
            }
            for (int col = 0; col < n; col++)
            {
                max = 0;
                for (int row = 0; row < n; row++)
                {
                    if (max < grid[row][col])
                        max = grid[row][col];
                }
                sum += max;
            }
            return sum;
        }
    }
}
