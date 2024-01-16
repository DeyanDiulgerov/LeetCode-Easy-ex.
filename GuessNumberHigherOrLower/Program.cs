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
/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */
            
            Console.WriteLine(GuessNumberHigherOrLower(10));
            Console.WriteLine(GuessNumberHigherOrLower(1));
            Console.WriteLine(GuessNumberHigherOrLower(2));
        }

        public static int GuessNumberHigherOrLower(int n)
        {
            int left = 0, right = n;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int ourGuess = guess(mid);

                if (ourGuess == -1)
                    right = mid - 1;
                else if (ourGuess == 1)
                    left = mid + 1;
                else
                    return mid;
            }
            return -1;
        }
    }
}
