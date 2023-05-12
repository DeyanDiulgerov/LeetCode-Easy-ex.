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
            //Partitions ???
            // n = 2                       n = 3
            // 1. 1 + 1 step               1. 1 + 1 + 1 steps
            // 2. 2 steps                  2. 2 + 1 steps
            //3. 1 + 2 steps

            // n = 4
            // 2 + 2 steps
            // 2 + 1 + 1 steps
            // 1 + 1 + 1 + 1 steps
            // 1 + 2 + 1 steps
            // 1 + 1 + 2 steps
            if (n <= 2)
                return n;

            var result = new int[n + 1];
            result[1] = 1;
            result[2] = 2;

            for (int i = 3; i <= n; i++)
                result[i] = result[i - 1] + result[i - 2];

            return result[n];

        }
    }
}
