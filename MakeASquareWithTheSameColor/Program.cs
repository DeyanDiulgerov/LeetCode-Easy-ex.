using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeASquareWithTheSameColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new char[][]
            {
                new char[] {'B', 'W', 'B'},
                new char[] {'B', 'W', 'W'},
                new char[] {'B', 'W', 'B'},
            };
            var grid2 = new char[][]
            {
                new char[] {'B', 'W', 'B'},
                new char[] {'W', 'B', 'W'},
                new char[] {'B', 'W', 'B'},
            };
            var grid3 = new char[][]
            {
                new char[] {'B', 'W', 'B'},
                new char[] {'B', 'W', 'W'},
                new char[] {'B', 'W', 'W'},
            };
            Console.WriteLine(MakeASquareWithTheSameColor(grid1));
            Console.WriteLine(MakeASquareWithTheSameColor(grid2));
            Console.WriteLine(MakeASquareWithTheSameColor(grid3));
        }
        public static bool MakeASquareWithTheSameColor(char[][] grid)
        {
            int n = grid.Length;//== grid[0].Length == 3 in this exercise but wanted to do it for other cases as well;
            for (int row = 0; row < n - 1; row++)
            {
                for (int col = 0; col < n - 1; col++)
                {
                    if (Check2x2SqauresNeighboursInGrid(grid, row, col))
                        return true;
                }
            }
            return false;
        }
        public static bool Check2x2SqauresNeighboursInGrid(char[][] grid, int row, int col)
        {
            int blackCount = 0;
            if (grid[row][col] == 'B')
                blackCount++;
            if (grid[row + 1][col] == 'B')
                blackCount++;
            if (grid[row][col + 1] == 'B')
                blackCount++;
            if (grid[row + 1][col + 1] == 'B')
                blackCount++;
            return blackCount != 2;
        }
    }
}
