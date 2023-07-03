using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsToeplitzMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix1 = new int[][]
            {
                new int[] {1,2,3,4},
                new int[] {5,1,2,3},
                new int[] {9,5,1,2 },
            };

            var matrix2 = new int[][]
            {
                new int[] {1,2},
                new int[] {2,2}
            };

            var matrix3 = new int[][]
            {
                new int[] {41,45},
                new int[] {81,41},
                new int[] {73,81},
                new int[] {47,73},
                new int[] {0,47},
                new int[] {79,76},
            };

            Console.WriteLine(IsToeplitzMatrix(matrix3));
            Console.WriteLine(IsToeplitzMatrix(matrix1));
            Console.WriteLine(IsToeplitzMatrix(matrix2));
        }

        public static bool IsToeplitzMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (row < matrix.Length - 1 && col < matrix[row].Length - 1)
                    {
                        for (int i = 0; i < matrix[row].Length; i++)
                        {
                            if (matrix[row][col] == matrix[row + 1][col + 1])
                            {

                            }
                            else
                                return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
