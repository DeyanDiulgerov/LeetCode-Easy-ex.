using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReshapeTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var mat1 = new int[][]
            {
                new int[] {1,2},
                new int[] {3,4},
            };

            var mat2 = new int[][]
           {
                new int[] {1,2},
                new int[] {3,4},
           };

            var input1 = ReshapeTheMatrix(mat1, 1, 4);
            var input2 = ReshapeTheMatrix(mat1, 2, 4);

            foreach (var item in input1)
                Console.WriteLine(String.Join(",", item));
            foreach (var item in input2)
                Console.WriteLine(String.Join(",", item));
        }

        public static int[][] ReshapeTheMatrix(int[][] mat, int r, int c)
        {
            int n = mat.Length;
            int m = mat[0].Length;

            if (m * n != r * c)
                return mat;

            int[][] arr = new int[r][];
            for (int i = 0; i < r; i++)
                arr[i] = new int[c];

            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < m; row++)
                {
                    int l = col * m + row;
                    arr[l / c][l % c] = mat[col][row];
                }
            }

            return arr;
        }
    }
}
