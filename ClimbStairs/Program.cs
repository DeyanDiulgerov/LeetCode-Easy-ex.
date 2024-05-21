using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbStairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //n steps to reach the top
            //you climb 1 or 2 steps each time
            //in how many diffrent ways can you climb to the top?

            Console.WriteLine(ClimbStairs(2));
            Console.WriteLine(ClimbStairs(3));
            Console.WriteLine(ClimbStairs(4));
            Console.WriteLine(ClimbStairs(5));
            Console.WriteLine(ClimbStairs(6));
            Console.WriteLine(ClimbStairs(7));
            Console.WriteLine(ClimbStairs(8));
        }

        public static int ClimbStairs(int n)
        {
            if(n <= 2)
                return n;
            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;
            for(int i = 3; i <= n; i++)
                dp[i] = dp[i - 1] + dp[i - 2];
            return dp[n];
        }
    }
}
