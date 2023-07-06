using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindColumnWidthOfAGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grid1 = new int[][]
            {
                new int[] {1},
                new int[] {22},
                new int[] {333},
            };

            int[][] grid2 = new int[][]
            {
                new int[] {-15,1,3},
                new int[] {15,7,12},
                new int[] {5,6,-2},
            };

            Console.WriteLine(String.Join(",", FindColumnWidthOfAGrid(grid1)));
            Console.WriteLine(String.Join(",", FindColumnWidthOfAGrid(grid2)));
        }

        public static int[] FindColumnWidthOfAGrid(int[][] grid)
        {
            int counter = 0;
            var resultList = new List<int>();

            for (int i = 0; i < grid[0].Count(); i++)
            {
                var allLengthsList = new List<int>();

                foreach (var arr in grid)
                {
                    var countIt = arr[counter].ToString().ToCharArray();
                    var length = countIt.Length;

                    allLengthsList.Add(length);
                }

                counter++;
                resultList.Add(allLengthsList.Max());
            }

            return resultList.ToArray();
        }
    }
}
