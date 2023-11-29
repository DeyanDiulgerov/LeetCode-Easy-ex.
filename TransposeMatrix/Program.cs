using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransposeMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new int[][]
            {
                new int[] {1,2,3},
                new int[] {4,5,6},
                new int[] {7,8,9},
            };
            var grid2 = new int[][]
            {
                new int[] {1,2,3},
                new int[] {4,5,6},
            };
            foreach (var item in TransposeMatrix(grid1))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in TransposeMatrix(grid2))
                Console.WriteLine(String.Join(",", item));
        }
        public static int[][] TransposeMatrix(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            var resultMatrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                var newArr = new int[m];
                for (int j = 0; j < m; j++)
                    newArr[j] = matrix[j][i];

                resultMatrix[i] = newArr;
            }
            return resultMatrix;
        }
    }
}
