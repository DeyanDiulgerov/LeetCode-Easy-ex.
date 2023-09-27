using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfMatchesInTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountOfMatchesInTournament(7));
            Console.WriteLine(CountOfMatchesInTournament(14));
        }

        public static int CountOfMatchesInTournament(int n)
        {
            int allMathces = 0;
            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    allMathces += n / 2;
                    n -= n / 2;
                }
                else
                {
                    allMathces += (n - 1) / 2;
                    n -= (n - 1) / 2;
                }
            }
            return allMathces;
        }
    }
}
