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
            int res = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                res += Math.Max(Math.Abs((points[i + 1][0] - points[i][0]))
                                , Math.Abs((points[i + 1][1] - points[i][1])));
            }

            return res;
        }
    }
}
