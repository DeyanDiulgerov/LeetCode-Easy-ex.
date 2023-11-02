using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellsWithOddValuesInAMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CellsWithOddValuesInAMatrix(2, 3, new int[][] { new int[] { 0, 1 }, new int[] { 1, 1 } }));
            Console.WriteLine(CellsWithOddValuesInAMatrix(2, 2, new int[][] { new int[] { 1, 1 }, new int[] { 0, 0 } }));
        }

        public static int CellsWithOddValuesInAMatrix(int m, int n, int[][] indices)
        {
            var matrix = new int[m][];
            for (int i = 0; i < matrix.Length; i++)
            {
                var newArr = new int[n];
                for (int j = 0; j < newArr.Length; j++)
                    newArr[j] = 0;

                matrix[i] = newArr;
            }
            for (int i = 0; i < indices.Length; i++)
            {
                var row = indices[i][0];
                var col = indices[i][1];

                for (int j = 0; j < n; j++)
                    matrix[row][j]++;
                for (int j = 0; j < m; j++)
                    matrix[j][col]++;
            }
            int result = 0;
            foreach (var item in matrix)
                result += item.Count(x => x % 2 != 0);

            return result;
        }
    }
}
