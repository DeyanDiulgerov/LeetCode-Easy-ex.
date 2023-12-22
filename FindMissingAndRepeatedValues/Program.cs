using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingAndRepeatedValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new int[][]
            {
                new int[] {1,3},
                new int[] {2,2},
            };
            var grid2 = new int[][]
            {
                new int[] {9,1,7},
                new int[] {8,9,2},
                new int[] {3,4,6},
            };
            Console.WriteLine(String.Join(",", FindMissingAndRepeatedValues(grid1)));
            Console.WriteLine(String.Join(",", FindMissingAndRepeatedValues(grid2)));
        }

        public static int[] FindMissingAndRepeatedValues(int[][] grid)
        {
            int n = grid.Length;
            int maxNum = n * n;
            Dictionary<int, int> valueAndFrequencyMap = new Dictionary<int, int>();
            int[] result = new int[2];

            for (int i = 1; i <= maxNum; i++)
                valueAndFrequencyMap.Add(i, 0);

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (valueAndFrequencyMap[grid[row][col]] < 2)
                        valueAndFrequencyMap[grid[row][col]]++;
                    if (valueAndFrequencyMap[grid[row][col]] == 2)
                        result[0] = grid[row][col];
                }
            }
            int missingNum = valueAndFrequencyMap.Where(x => x.Value == 0).First().Key;
            result[1] = missingNum;
            return result;
        }
    }
}
