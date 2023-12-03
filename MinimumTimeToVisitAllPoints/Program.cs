using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumTimeToVisitAllPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var points1 = new int[][]
            {
                new int[]{1,1},
                new int[]{3,4},
                new int[]{-1,0},
            };

            var points2 = new int[][]
            {
                new int[]{3,2},
                new int[]{-2,2},
            };

            Console.WriteLine(MinimumTimeToVisitAllPoints(points1));
            Console.WriteLine(MinimumTimeToVisitAllPoints(points2));
        }

        public static int MinimumTimeToVisitAllPoints(int[][] points)
        {
            int counter = 0;

            for (int i = 1; i < points.Length; i++)
            {
                var first = Math.Abs(points[i][0] - points[i - 1][0]);
                var second = Math.Abs(points[i][1] - points[i - 1][1]);

                counter += Math.Max(first, second);
            }
            return counter;
        }
    }
}
