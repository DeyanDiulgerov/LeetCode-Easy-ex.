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
            int[][] mat1 = new int[][]
            {
                new int[] {1,2,3},
                new int[] {4,5,6},
                new int[] {7,8,9},
            };
            foreach (var item in mat1)
            {
                Console.WriteLine(String.Join(",", item));
            }

            int[][] mat2 = new int[][]
            {
                new int[] {1,1,1,1 },
                new int[] {1,1,1,1},
                new int[] {1,1,1,1},
                new int[] {1,1,1,1},
            };
            foreach (var item in mat2)
            {
                Console.WriteLine(String.Join(",", item));
            }

            int[][] mat3 = new int[][]
            {
                new int[] {5 },
            };
            foreach (var item in mat3)
            {
                Console.WriteLine(String.Join(",", item));
            }


            Console.WriteLine(DiagonalSum(mat1));
            Console.WriteLine(DiagonalSum(mat2));
            Console.WriteLine(DiagonalSum(mat3));
        }

        public static int DiagonalSum(int[][] mat)
        {
            if (mat.Length == 1)
                return mat.First().First();

            int sum = 0;
            var test = new Dictionary<double, double>();

            for (int row = 0; row < mat.Length - 1; row++)
            {
                for (int col = 0; col < mat.Length - 1; col++)
                {
                    while (row != mat.Length && col != mat.Length)
                    {
                        sum += mat[row][col];
                        test.Add(row, col);
                        row++;
                        col++;
                    }
                }
            }

            for (int row = mat.Length - 1; row >= 0; row--)
            {
                for (int col = 0; col < mat.Length - 1; col++)
                {
                    while (true)
                    {

                        if (!test.Any(x => x.Key == row && x.Value == col))
                            sum += mat[row][col];

                        if (row == 0 || col == mat.Length)
                            return sum;
                        row--;
                        col++;

                    }
                }
            }

            return sum;
        }
    }
}
