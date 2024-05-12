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
            int n = grid.Length;
            int[][] res = new int[n - 2][];
            for (int row = 0; row < n - 2; row++)
            {
                int[] newRow = new int[n - 2];
                for (int col = 0; col < n - 2; col++)
                {
                    int max = 0;
                    for (int r = row; r < row + 3; r++)
                        for (int c = col; c < col + 3; c++)
                            max = Math.Max(max, grid[r][c]);
                    newRow[col] = max;
                }
                res[row] = newRow;
            }
            return res;
        }
    }
}
