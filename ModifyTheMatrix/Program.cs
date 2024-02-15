using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyTheMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrix1 = new int[][]
            {
                new int[] {1,2,-1},
                new int[] {4,-1,6},
                new int[] {7,8,9},
            };
            var matrix2 = new int[][]
            {
                new int[] {3,-1},
                new int[] {5,2},
            };
            foreach (var item in ModifyTheMatrixMap(matrix1))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in ModifyTheMatrixMap(matrix2))
                Console.WriteLine(String.Join(",", item));
        }
        // Brute-force search
        public int[][] ModifiedMatrix(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int[][] result = new int[m][];
            for (int row = 0; row < m; row++)
            {
                int[] resRow = new int[n];
                for (int col = 0; col < n; col++)
                {
                    int max = matrix[row][col];
                    if (matrix[row][col] == -1)
                    {
                        for (int r = 0; r < m; r++)
                            max = Math.Max(max, matrix[r][col]);
                    }
                    resRow[col] = max;
                }
                result[row] = resRow;
            }
            return result;
        }
        // Mapping every column with its max
        public static int[][] ModifyTheMatrixMap(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int[][] result = new int[m][];
            var mapColAndMax = new Dictionary<int, int>();
            for (int col = 0; col < n; col++)
            {
                int max = 0;
                for (int row = 0; row < m; row++)
                    max = Math.Max(max, matrix[row][col]);

                mapColAndMax.Add(col, max);
            }
            for (int row = 0; row < m; row++)
            {
                int[] resRow = new int[n];
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row][col] == -1)
                        resRow[col] = mapColAndMax[col];
                    else
                        resRow[col] = matrix[row][col];
                }
                result[row] = resRow;
            }
            return result;
        }
    }
}
