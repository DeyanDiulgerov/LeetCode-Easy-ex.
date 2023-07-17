using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestLocalValuesInAMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new int[][]
            {
                new int[] {9,9,8,1},
                new int[] {5,6,2,6},
                new int[] {8,2,6,4},
                new int[] {6,2,2,2},
            };

            var grid2 = new int[][]
           {
                new int[] {1,1,1,1,1},
                new int[] {1,1,1,1,1},
                new int[] {1,1,2,1,1},
                new int[] {1,1,1,1,1},
                new int[] {1,1,1,1,1},
           };

            var result1 = LargestLocalValuesInAMatrix(grid1);
            var result2 = LargestLocalValuesInAMatrix(grid2);

            foreach (var item in result1)
                Console.WriteLine(String.Join(",", item));

            foreach (var item in result2)
                Console.WriteLine(String.Join(",", item));
        }

        public static int[][] LargestLocalValuesInAMatrix(int[][] grid)
        {
            int n = grid.Length - 2;
            int[][] result = new int[n][];

            for (int i = 0; i < n; i++)
            {
                result[i] = new int[n];
                for (int j = 0; j < n; j++)
                    result[i][j] = MaxFinder(i, j, grid);
            }
            return result;
        }

        private static int MaxFinder(int x, int y, int[][] grid)
        {
            int max = int.MinValue;
            for (int i = x; i < x + 3; i++)
                for (int j = y; j < y + 3; j++)
                    if (max < grid[i][j])
                        max = grid[i][j];
            return max;
        }
    }
}
