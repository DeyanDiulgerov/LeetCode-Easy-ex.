using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWinnerOnATicTacToeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var moves1 = new int[][]
            {
                new int[] {0,0},
                new int[] {2,0},
                new int[] {1,1},
                new int[] {2,1},
                new int[] {2,2},
            };
            var moves2 = new int[][]
           {
                new int[] {0,0},
                new int[] {1,1},
                new int[] {0,1},
                new int[] {0,2},
                new int[] {1,0},
                new int[] {2,0},
           };
            var moves3 = new int[][]
          {
                new int[] {0,0},
                new int[] {1,1},
                new int[] {2,0},
                new int[] {1,0},
                new int[] {1,2},
                new int[] {2,1},
                new int[] {0,1},
                new int[] {0,2},
                new int[] {2,2},
          };
            var moves4 = new int[][]
          {
                new int[] {2,0},
                new int[] {0,1},
                new int[] {0,2},
                new int[] {2,2},
                new int[] {1,2},
                new int[] {2,1},
                new int[] {1,0},
                new int[] {0,0},
                new int[] {1,1},
          };
            Console.WriteLine(FindWinnerOnATicTacToeGame(moves4));
            Console.WriteLine(FindWinnerOnATicTacToeGame(moves1));
            Console.WriteLine(FindWinnerOnATicTacToeGame(moves2));
            Console.WriteLine(FindWinnerOnATicTacToeGame(moves3));
        }

        public static string FindWinnerOnATicTacToeGame(int[][] moves)
        {
            // Initialize matrix
            var grid = new char[3][];
            for (int row = 0; row < 3; row++)
            {
                var newArr = new char[3];
                for (int col = 0; col < 3; col++)
                {
                    newArr[col] = ' ';
                }
                grid[row] = newArr;
            }
            // Fill out matrix
            for (int i = 0; i < moves.Length; i++)
            {
                char curr = ' ';
                if (i == 0 || i % 2 == 0)
                    curr = 'X';
                else
                    curr = 'O';

                grid[moves[i][0]][moves[i][1]] = curr;
            }
            foreach (var item in grid)
                Console.WriteLine(String.Join(",", item));

            // Check Winner
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    char curr = grid[row][col];
                    if (curr == ' ')
                        continue;

                    bool isWinner = CheckNeighbours(grid, row, col, 3, 3, curr);
                    if (isWinner)
                    {
                        if (curr == 'X')
                            return "A";
                        else
                            return "B";
                    }
                }
            }
            if (grid.Any(x => x.Contains(' ')))
                return "Pending";

            return "Draw";
        }

        public static bool CheckNeighbours(char[][] grid, int row, int col, int rows, int cols, char curr)
        {
            if (row + 1 < rows && grid[row + 1][col] == curr)
            {
                if (row + 2 < rows && grid[row + 2][col] == curr)
                    return true;
            }
            if (row + 1 < rows && col + 1 < cols && grid[row + 1][col + 1] == curr)
            {
                if (row + 2 < rows && col + 2 < cols && grid[row + 2][col + 2] == curr)
                    return true;
            }
            if (col + 1 < cols && grid[row][col + 1] == curr)
            {
                if (col + 2 < cols && grid[row][col + 2] == curr)
                    return true;
            }
            if (row - 1 >= 0 && grid[row - 1][col] == curr)
            {
                if (row - 2 >= 0 && grid[row - 2][col] == curr)
                    return true;
            }
            if (row - 1 >= 0 && col + 1 < cols && grid[row - 1][col + 1] == curr)
            {
                if (row - 2 >= 0 && col + 2 < cols && grid[row - 2][col + 2] == curr)
                    return true;
            }
            if (row - 1 >= 0 && col - 1 >= 0 && grid[row - 1][col - 1] == curr)
            {
                if (row - 2 >= 0 && col - 2 >= 0 && grid[row - 2][col - 2] == curr)
                    return true;
            }

            return false;
        }
    }
}
