using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumRookCaptures
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] board1 = new char[][]
            {
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'R', '.', '.', '.', 'p' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
            };

            char[][] board2 = new char[][]
            {
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', 'p', 'p', 'p', 'p', 'p', '.', '.' },
                new char[] { '.', 'p', 'p', 'B', 'p', 'p', '.', ',' },
                new char[] { '.', 'p', 'B', 'R', 'B', 'p', '.', '.' },
                new char[] { '.', 'p', 'p', 'B', 'p', 'p', '.', '.' },
                new char[] { '.', 'p', 'p', 'p', 'p', 'p', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
            };

            char[][] board3 = new char[][]
            {
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { 'p', 'p', '.', 'R', '.', 'p', 'B', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'B', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
            };

            Console.WriteLine(NumRookCaptures(board1));
            Console.WriteLine(NumRookCaptures(board2));
            Console.WriteLine(NumRookCaptures(board3));
        }

        public static int NumRookCaptures(char[][] board)
        {
            var rookRow = 0;
            var rookCol = 0;
            var permRookRow = 0;
            var permRookCol = 0;
            int counter = 0;

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (board[row][col] == 'R')
                    {
                        rookRow = row;
                        rookCol = col;
                        permRookRow = row;
                        permRookCol = col;
                    }
                }
            }

            //ROW
            while (rookRow < 8)
            {
                if (board[rookRow][rookCol] == 'B')
                    break;
                else if (board[rookRow][rookCol] == 'p')
                {
                    counter++;
                    break;
                }

                rookRow++;
            }
            rookRow = permRookRow;

            while (rookRow >= 0)
            {
                if (board[rookRow][rookCol] == 'B')
                    break;
                else if (board[rookRow][rookCol] == 'p')
                {
                    counter++;
                    break;
                }

                rookRow--;
            }
            rookRow = permRookRow;

            //COL
            while (rookCol < 8)
            {
                if (board[rookRow][rookCol] == 'B')
                    break;
                else if (board[rookRow][rookCol] == 'p')
                {
                    counter++;
                    break;
                }

                rookCol++;
            }
            rookCol = permRookCol;

            while (rookCol >= 0)
            {
                if (board[rookRow][rookCol] == 'B')
                    break;
                else if (board[rookRow][rookCol] == 'p')
                {
                    counter++;
                    break;
                }

                rookCol--;
            }
            rookCol = permRookCol;

            return counter;
        }
    }
}
