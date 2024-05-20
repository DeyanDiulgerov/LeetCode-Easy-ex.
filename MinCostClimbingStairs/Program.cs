using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinCostClimbingStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinCostClimbingStairs(new int[] { 10, 15, 20 }));
            Console.WriteLine(MinCostClimbingStairs(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }));
        }

        public static int MinCostClimbingStairs(int[] cost)
        {
            int n = cost.Length;
            for(int i = 2; i < n; i++)
                cost[i] += Math.Min(cost[i - 1], cost[i - 2]);
            return Math.Min(cost[n - 1], cost[n - 2]);
        }
    }
}
