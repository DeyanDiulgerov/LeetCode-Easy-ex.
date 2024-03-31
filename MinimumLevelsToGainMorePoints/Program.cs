using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumLevelsToGainMorePoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", MinimumLevelsToGainMorePoints(new int[] { 1, 0, 1, 0 })));
            Console.WriteLine(String.Join(",", MinimumLevelsToGainMorePoints(new int[] { 1, 1, 1, 1, 1 })));
        }
        public static int MinimumLevelsToGainMorePoints(int[] possible)
        {
            int ourSum = 0;
            int zeroCount = possible.Count(x => x == 0);
            int enemySum = possible.Sum();
            enemySum -= zeroCount;
            for (int i = 0; i < possible.Length - 1; i++)
            {
                if (possible[i] == 0)
                {
                    ourSum--;
                    enemySum++;
                }
                else
                {
                    ourSum++;
                    enemySum--;
                }
                if (ourSum > enemySum)
                    return i + 1;
            }
            return -1;
        }
    }
}
