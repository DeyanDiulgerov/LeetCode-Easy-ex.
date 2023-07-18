using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountGoodRectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangles1 = new int[][]
            {
                new int[] {5,8},
                new int[] {3,9},
                new int[] {5,12},
                new int[] {16,5},
            };

            var rectangles2 = new int[][]
           {
                new int[] {2,3},
                new int[] {3,7},
                new int[] {4,3},
                new int[] {3,7},
           };

            Console.WriteLine(CountGoodRectangles(rectangles1));
            Console.WriteLine(CountGoodRectangles(rectangles2));
        }

        public static int CountGoodRectangles(int[][] rectangles)
        {
            var allLengths = new List<int>();
            int counter = 0;

            foreach (var item in rectangles)
            {
                if (item[0] >= item[1])
                    allLengths.Add(item[1]);
                else
                    allLengths.Add(item[0]);
            }

            allLengths.Sort();
            int maxLen = allLengths.Last();

            foreach (var item in allLengths)
            {
                if (item == maxLen)
                    counter++;
            }

            return counter;
        }
    }
}
