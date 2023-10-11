using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularGameLosers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", CircularGameLosers(5, 2)));
            Console.WriteLine(String.Join(",", CircularGameLosers(4, 4)));
        }

        public static int[] CircularGameLosers(int n, int k)
        {
            bool[] game = new bool[n];
            int loopCounter = 1;

            for (int i = 0; !game[i]; i += 0)
            {
                game[i] = true;

                i = (i + loopCounter * k) % n;
                loopCounter++;
            }

            var losers = new List<int>();

            for (int i = 0; i < game.Length; i++)
            {
                if (!game[i])
                    losers.Add(i + 1);
            }

            return losers.ToArray();
        }
    }
}
