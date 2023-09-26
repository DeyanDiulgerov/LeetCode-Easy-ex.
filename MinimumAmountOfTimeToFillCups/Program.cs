using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumAmountOfTimeToFillCups
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumAmountOfTimeToFillCups(new int[] { 5, 4, 4 }));
            Console.WriteLine(MinimumAmountOfTimeToFillCups(new int[] { 1, 4, 2 }));
            Console.WriteLine(MinimumAmountOfTimeToFillCups(new int[] { 5, 0, 0 }));
        }

        public static int MinimumAmountOfTimeToFillCups(int[] amount)
        {
            int counter = 0;
            while (amount.Sum() > 0)
            {
                Array.Sort(amount);
                amount[2] = Math.Max(amount[2] - 1, 0);
                amount[1] = Math.Max(amount[1] - 1, 0);
                counter++;
            }

            return counter;
        }
    }
}
