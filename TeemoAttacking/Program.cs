using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeemoAttacking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TeemoAttacking(new int[] { 1, 4 }, 2));
            Console.WriteLine(TeemoAttacking(new int[] { 1, 2 }, 2));
            Console.WriteLine(TeemoAttacking(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5));
        }

        public static int TeemoAttacking(int[] timeSeries, int duration)
        {
            int count = 0;
            for (int i = 1; i < timeSeries.Length; i++)
            {
                if (timeSeries[i] - timeSeries[i - 1] > duration)
                    count += duration;
                else
                    count += timeSeries[i] - timeSeries[i - 1];
            }
            count += duration;
            return count;
        }
    }
}
