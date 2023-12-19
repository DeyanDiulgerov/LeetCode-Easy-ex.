using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageSmoother
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var img1 = new int[][]
            {
                new int[] { 1, 1, 1 },
                new int[] {1,0,1 },
                new int[] { 1,1,1 },
            };
            var img2 = new int[][]
           {
                new int[] { 100,200,100},
                new int[] {200,50,200},
                new int[] { 100,200,100 },
           };
            var img3 = new int[][]
          {
                new int[] { 2,3,4},
                new int[] {5,6,7},
                new int[] { 8,9,10 },
                new int[] {11,12,13 },
                new int[] {14,15,16 },
          };
            foreach (var item in ImageSmoother(img3))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in ImageSmoother(img1))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in ImageSmoother(img2))
                Console.WriteLine(String.Join(",", item));

        }
        public static int[][] ImageSmoother(int[][] img)
        {
            int m = img.Length;
            int n = img[0].Length;
            var resultImage = new int[m][];

            for (int row = 0; row < m; row++)
            {
                var newArr = new int[n];
                for (int col = 0; col < n; col++)
                {
                    var neighbourSumAndCountMap = GatherValuesFromNeighbours(img, row, col, m, n);
                    int sum = neighbourSumAndCountMap.First().Key;
                    int totalNums = neighbourSumAndCountMap.First().Value;

                    double final = sum / totalNums;
                    int result = (int)Math.Floor(final);
                    newArr[col] = result;
                }
                resultImage[row] = newArr;
            }
            return resultImage;
        }

        public static Dictionary<int, int> GatherValuesFromNeighbours(int[][] img, int row, int col, int rows, int cols)
        {
            int sum = 0;
            int allNumsCount = 0;
            var sumAndCountMap = new Dictionary<int, int>();

            sum += img[row][col];
            allNumsCount++;

            if (row >= 1 && col >= 1)
            {
                sum += img[row - 1][col - 1];
                allNumsCount++;
            }
            if (row >= 1)
            {
                sum += img[row - 1][col];
                allNumsCount++;
            }
            if (row >= 1 && col < cols - 1)
            {
                sum += img[row - 1][col + 1];
                allNumsCount++;
            }
            if (col >= 1)
            {
                sum += img[row][col - 1];
                allNumsCount++;
            }
            if (col < cols - 1)
            {
                sum += img[row][col + 1];
                allNumsCount++;
            }
            if (col >= 1 && row < rows - 1)
            {
                sum += img[row + 1][col - 1];
                allNumsCount++;
            }
            if (row < rows - 1)
            {
                sum += img[row + 1][col];
                allNumsCount++;
            }
            if (col < cols - 1 && row < rows - 1)
            {
                sum += img[row + 1][col + 1];
                allNumsCount++;
            }

            sumAndCountMap.Add(sum, allNumsCount);
            return sumAndCountMap;
        }
    }
}
