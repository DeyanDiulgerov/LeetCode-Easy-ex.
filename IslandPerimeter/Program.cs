using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslandPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new int[][]
            {
                new int[] {0,1,0,0},
                new int[] {1,1,1,0},
                new int[] {0,1,0,0},
                new int[] {1,1,0,0},
            };
            var grid2 = new int[][]
            {
                new int[] {1}
            };

            var grid3 = new int[][]
            {
                new int[] {1,0 },
            };

            Console.WriteLine(String.Join(",", IslandPerimeter(grid1)));
            Console.WriteLine(String.Join(",", IslandPerimeter(grid2)));
            Console.WriteLine(String.Join(",", IslandPerimeter(grid3)));
        }

        public static int IslandPerimeter(int[][] grid)
        {
            var result = 0;

            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {
                    if (grid[row][col] == 1)
                        result += countPerimeter(grid, row, col);
                }
            }

            return result;
        }
        public static int countPerimeter(int[][] grid, int row, int col)
        {
            int count = 0;

            if (row - 1 < 0 || grid[row - 1][col] == 0)
                count++;
            if (row + 1 > grid.Length - 1 || grid[row + 1][col] == 0)
                count++;
            if (col - 1 < 0 || grid[row][col - 1] == 0)
                count++;
            if (col + 1 > grid[row].Length - 1 || grid[row][col + 1] == 0)
                count++;

            return count;
        }
    }
}
