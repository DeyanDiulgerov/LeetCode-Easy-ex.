using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteGreatestValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grid1 = new int[][]
            {
                new int[] {1,2,4},
                new int[] {3,3,1}
            };

            int[][] grid2 = new int[][]
            {
                new int[] {10},
            };

            Console.WriteLine(DeleteGreatestValue(grid1));
            Console.WriteLine(DeleteGreatestValue(grid2));
        }

        public static int DeleteGreatestValue(int[][] grid)
        {
            int sum = 0;

            foreach (var row in grid)
                Array.Sort(row);

            for (var i = 0; i < grid[0].Length; i++)
                sum += grid.Select(row => row[i]).Max();

            return sum;
        }
    }
}
