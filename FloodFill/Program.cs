using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloodFill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var image1 = new int[][]
            {
                new int[] {1,1,1},
                new int[] {1,1,0},
                new int[] {1,0,1},
            };
            var image2 = new int[][]
           {
                new int[] {0,0,0},
                new int[] {0,0,0},
           };
            foreach (var item in FloodFill(image1, 1, 1, 2))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in FloodFill(image2, 0, 0, 0))
                Console.WriteLine(String.Join(",", item));
        }
        public static int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            int m = image.Length;
            int n = image[0].Length;
            int oldColor = image[sr][sc];

            if (color != oldColor)
                CheckNeighbours(image, sr, sc, m, n, color, oldColor);

            return image;
        }

        public static void CheckNeighbours
            (int[][] image, int row, int col, int rows, int cols, int color, int oldColor)
        {
            image[row][col] = color;

            if (row - 1 >= 0 && image[row - 1][col] == oldColor)
            {
                image[row - 1][col] = color;
                CheckNeighbours(image, row - 1, col, rows, cols, color, oldColor);
            }
            if (row + 1 < rows && image[row + 1][col] == oldColor)
            {
                image[row + 1][col] = color;
                CheckNeighbours(image, row + 1, col, rows, cols, color, oldColor);
            }
            if (col - 1 >= 0 && image[row][col - 1] == oldColor)
            {
                image[row][col - 1] = color;
                CheckNeighbours(image, row, col - 1, rows, cols, color, oldColor);
            }
            if (col + 1 < cols && image[row][col + 1] == oldColor)
            {
                image[row][col + 1] = color;
                CheckNeighbours(image, row, col + 1, rows, cols, color, oldColor);
            }
        }
    }
}
