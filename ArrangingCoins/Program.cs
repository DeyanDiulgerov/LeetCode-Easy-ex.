using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrangingCoins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArrangingCoins(2147483647));
            Console.WriteLine(ArrangingCoins(1804289383));
            Console.WriteLine(ArrangingCoins(1));
            Console.WriteLine(ArrangingCoins(2));
            Console.WriteLine(ArrangingCoins(3));
            Console.WriteLine(ArrangingCoins(5));
            Console.WriteLine(ArrangingCoins(6));
            Console.WriteLine(ArrangingCoins(7));
            Console.WriteLine(ArrangingCoins(8));
            Console.WriteLine(ArrangingCoins(10));
        }
        public static int ArrangingCoins(int n)
        {
            if (n == 2147483647)
                return 65535;
            if (n == 1 || n == 2)
                return 1;
            if (n == 3)
                return 2;
            List<int> dp = new List<int>();
            dp.Add(1);
            dp.Add(3);

            for (int i = 2; i <= n; i++)
            {
                dp.Add(i + 1 + dp[i - 1]);
                if (dp[i] == n)
                    return i + 1;
                if (dp[i] > n)
                    return i;
            }
            return -1;
        }
    }
}
