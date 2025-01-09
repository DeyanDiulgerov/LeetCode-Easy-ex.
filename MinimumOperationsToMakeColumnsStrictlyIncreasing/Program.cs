using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumOperationsToMakeColumnsStrictlyIncreasing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new int[][]
            {
                new int[] {3,2},
                new int[] {1,3},
                new int[] {3,4},
                new int[] {0,1},
            };
            var grid2 = new int[][]
            {
                new int[] {3,2,1},
                new int[] {2,1,0},
                new int[] {1,2,3},
            };
            var grid3 = new int[][]
            {
                new int[] {0},
                new int[] {50},
            };
            Console.WriteLine(MinimumOperationsToMakeColumnsStrictlyIncreasing(grid3));
            Console.WriteLine(MinimumOperationsToMakeColumnsStrictlyIncreasing(grid1));
            Console.WriteLine(MinimumOperationsToMakeColumnsStrictlyIncreasing(grid2));
        }

        public static int MinimumOperationsToMakeColumnsStrictlyIncreasing(int[][] grid)
        {
            int count = 0;
            for (int col = 0; col < grid[0].Length; col++)
            {
                int prevNum = grid[0][col];
                for (int row = 1; row < grid.Length; row++)
                {
                    if (grid[row][col] > prevNum)
                    {
                        prevNum = grid[row][col];
                        continue;
                    }
                    int newNum = prevNum - grid[row][col] + 1;
                    count += newNum;
                    prevNum = grid[row][col] + newNum;
                }
            }
            return count;
        }
    }
}
