using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixDiagonalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] mat1 = new int[][]
            {
                new int[] {1,2,3},
                new int[] {4,5,6},
                new int[] {7,8,9},
            };
            int[][] mat2 = new int[][]
            {
                new int[] {1,1,1,1},
                new int[] {1,1,1,1},
                new int[] {1,1,1,1},
                new int[] {1,1,1,1},
            };
            int[][] mat3 = new int[][]
            {
                new int[] {5},
            };
            Console.WriteLine(MatrixDiagonalSum(mat1));
            Console.WriteLine(MatrixDiagonalSum(mat2));
            Console.WriteLine(MatrixDiagonalSum(mat3));
        }
        public static int MatrixDiagonalSum(int[][] mat)
        {
            int n = mat.Length;//= mat[0].Length;
            int sum = 0;
            int row = 0, col = 0;
            while (row < n && col < n)
            {
                sum += mat[row][col];
                row++;
                col++;
            }
            row = 0;
            col = n - 1;
            while (row < n && col >= 0)
            {
                sum += mat[row][col];
                row++;
                col--;
            }
            if (n % 2 != 0)
                sum -= mat[n / 2][n / 2];
            return sum;
        }
    }
}
