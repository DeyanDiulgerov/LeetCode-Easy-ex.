using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNearestPointThatHasTheSameXorYCoordinate
{
    class Program
    {
        static void Main(string[] args)
        {
            var points1 = new int[][]
            {
                new int[] {1,2},
                new int[] {3,1},
                new int[] {2,4},
                new int[] {2,3},
                new int[] {4,4},
            };

            var points2 = new int[][]
            {
                new int[] {3,4}
            };
            var points3 = new int[][]
            {
                new int[] {2,3}
             };

            Console.WriteLine(FindNearestPointThatHasTheSameXorYCoordinate(3, 4, points1));
            Console.WriteLine(FindNearestPointThatHasTheSameXorYCoordinate(3, 4, points2));
            Console.WriteLine(FindNearestPointThatHasTheSameXorYCoordinate(3, 4, points3));
        }
        public static int FindNearestPointThatHasTheSameXorYCoordinate(int x, int y, int[][] points)
        {
            var allPointsDict = new Dictionary<int[], int>();

            foreach (var p in points)
            {
                if (p[0] == x || p[1] == y)
                    allPointsDict.Add(new int[] { p[0], p[1] }, Array.IndexOf(points, p));
            }

            var manhatanAndIndexDict = new Dictionary<int, int>();

            foreach (var p in allPointsDict)
            {
                var manhatanDistance = Math.Abs(x - p.Key[0]) + Math.Abs(y - p.Key[1]);

                if (!manhatanAndIndexDict.ContainsKey(manhatanDistance))
                    manhatanAndIndexDict.Add(manhatanDistance, p.Value);
            }

            if (manhatanAndIndexDict.Count() == 0)
                return -1;

            foreach (var kvp in manhatanAndIndexDict.OrderBy(m => m.Key).ThenBy(m => m.Value))
                return kvp.Value;

            return 1;
        }
    }
}
