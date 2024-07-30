using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheWinningPlayerInCoinGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheWinningPlayerInCoinGame(2, 7));
            Console.WriteLine(FindTheWinningPlayerInCoinGame(4, 11));
        }
        public static string FindTheWinningPlayerInCoinGame(int x, int y)
        {
            int turnCount = 0;
            string res = "Bob";
            while (x > 0 && y > 3)
            {
                x--;
                y -= 4;
                if (turnCount != 0)
                {
                    turnCount = 0;
                    res = "Bob";
                }
                else
                {
                    turnCount = -1;
                    res = "Alice";
                }

            }
            return res;
        }
    }
}
