using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberHigherOrLower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GuessNumberHigherOrLower(10));
            Console.WriteLine(GuessNumberHigherOrLower(1));
            Console.WriteLine(GuessNumberHigherOrLower(2));
        }

        public static int GuessNumberHigherOrLower(int n)
        {
            /** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */
            int l = 0, r = n;

            while (true)
            {
                int m = l + (r - l) / 2;
                var res = guess(m);

                if (res > 0)
                    l = m + 1;
                else if (res < 0)
                    r = m - 1;
                else
                    return m;
            }
            return n;
        }
    }
}
