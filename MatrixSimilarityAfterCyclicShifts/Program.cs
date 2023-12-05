using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSimilarityAfterCyclicShifts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mat1 = new int[][]
            {
                new int[] {1,2,1,2},
                new int[] {5,5,5,5},
                new int[] {6,3,6,3},
            };
            var mat2 = new int[][]
            {
                new int[] {2,2},
                new int[] {2,2},
            };
            var mat3 = new int[][]
            {
                new int[] {1,2},
            };
            var mat4 = new int[][]
           {
                new int[] {3,10,3,10,3,10,3,10},
                new int[] {5,8,5,8,5,8,5,8},
                new int[] {3,9,3,9,3,9,3,9},
                new int[] {3,8,3,8,3,8,3,8},
                new int[] {2,3,2,3,2,3,2,3},
           };

            Console.WriteLine(MatrixSimilarityAfterCyclicShifts(mat4, 2));
            Console.WriteLine(MatrixSimilarityAfterCyclicShifts(mat1, 2));
            Console.WriteLine(MatrixSimilarityAfterCyclicShifts(mat2, 3));
            Console.WriteLine(MatrixSimilarityAfterCyclicShifts(mat3, 1));
        }

        public static bool MatrixSimilarityAfterCyclicShifts(int[][] mat, int k)
        {
            int m = mat.Length;
            int n = mat[0].Length;
            var newMatrix = new int[m][];

            for (int row = 0; row < m; row++)
            {
                var newArr = new int[n];
                for (int i = 0; i < n; i++)
                    newArr[i] = mat[row][i];

                for (int i = 0; i < k; i++)
                {
                    var temp = 0;
                    if (row == 0 || row % 2 == 0)
                    {
                        temp = newArr[0];
                        for (int col = 0; col < n - 1; col++)
                            newArr[col] = newArr[col + 1];

                        newArr[n - 1] = temp;
                    }
                    else
                    {
                        temp = newArr[n - 1];
                        for (int col = n - 1; col >= 1; col--)
                            newArr[col] = newArr[col - 1];

                        newArr[0] = temp;
                    }
                }
                newMatrix[row] = newArr;
            }

            for (int row = 0; row < m; row++)
                for (int col = 0; col < n; col++)
                    if (mat[row][col] != newMatrix[row][col])
                        return false;

            return true;
        }
    }
}
