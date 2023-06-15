using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix1 = new int[][]
            {
                new int[] {1,2,3 },
                new int[] {4,5,6 },
                new int[] {7,8,9 },
            };
            Console.WriteLine(DiagonalSumMatrix(matrix1));

            int[][] matrix2 = new int[][]
            {
                new int[] {1,1,1,1 },
                new int[] {1,1,1,1 },
                new int[] {1,1,1,1 },
                new int[] {1,1,1,1 },
            };
            Console.WriteLine(DiagonalSumMatrix(matrix2));

            int[][] matrix3 = new int[][]
            {
                new int[] {5 },
            };
            Console.WriteLine(DiagonalSumMatrix(matrix3));
        }

        public static int DiagonalSumMatrix(int[][] mat)
        {
            // square matrix
            int n = mat.GetLength(0);

            int sum = 0;
            var dictNums = new Dictionary<int, int>();

            for (int row = 0; row <= n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (!dictNums.Any(x => x.Key == row && x.Value == col))
                    {
                        sum += mat[row][col];
                        dictNums.Add(row, col);
                    }
                    row++;
                }
            }

            for (int row = n - 1; row >= 0; row--)
            {
                for (int col = 0; col < n; col++)
                {
                    if (!dictNums.Any(x => x.Key == row && x.Value == col))
                        sum += mat[row][col];

                    row--;
                }
            }

            return sum;
        }
    }
}
