using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfMatrixIsXMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grid1 = new int[][]
            {
                new int[] {2,0,0,1},
                new int[] {0,3,1,0},
                new int[] {0,5,2,0 },
                new int[] {4,0,0,2 },
            };

            int[][] grid2 = new int[][]
            {
                new int[] {5,7,0},
                new int[] {0,3,1},
                new int[] {0,5,0},
            };

            int[][] grid3 = new int[][]
            {
                new int[] {2,0,0,0,1 },
                new int[] {0,4,0,1,5 },
                new int[] {0,0,5,0,0 },
                new int[] {0,5,0,2,0 },
                new int[] {4,0,0,0,2 },
            };

            Console.WriteLine(CheckIfMatrixIsXMatrix(grid3));
            Console.WriteLine(CheckIfMatrixIsXMatrix(grid2));
            Console.WriteLine(CheckIfMatrixIsXMatrix(grid1));
        }

        public static bool CheckIfMatrixIsXMatrix(int[][] grid)
        {
            var allNums = new List<int>();

            foreach (var item in grid)
            {
                foreach (var num in item)
                {
                    allNums.Add(num);
                }
            }

            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {
                    if (grid[row][col] == 0)
                        return false;

                    Console.WriteLine(grid[row][col]);

                    if ((grid.Length - 1) % 2 == 0)
                    {
                        if (row != (grid.Length - 1) / 2 && col != (grid.Length - 1) / 2)
                            allNums.Remove(grid[row][col]);
                    }
                    else if (grid.Length % 2 == 0)
                    {
                        allNums.Remove(grid[row][col]);
                    }

                    if (row != grid.Length - 1)
                        row++;
                }
            }

            for (int row = grid.Length - 1; row >= 0; row--)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {
                    if (grid[row][col] == 0)
                        return false;

                    Console.WriteLine(grid[row][col]);
                    allNums.Remove(grid[row][col]);

                    if (row != 0)
                        row--;
                }
            }

            Console.WriteLine(String.Join(",", allNums));

            if (allNums.Any(x => x != 0))
                return false;

            return true;
        }
    }
}
