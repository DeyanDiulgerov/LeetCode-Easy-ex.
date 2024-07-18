using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPairsThatFormACompleteDayI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountPairsThatFormACompleteDayI(new int[] { 12, 12, 30, 24, 24 }));
            Console.WriteLine(CountPairsThatFormACompleteDayI(new int[] { 72, 48, 24, 3 }));
        }
        public static int CountPairsThatFormACompleteDayI(int[] hours)
        {
            int n = hours.Length;
            int pairs = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((hours[i] + hours[j]) % 24 == 0)
                        pairs++;
                }
            }
            return pairs;
        }
    }
}
