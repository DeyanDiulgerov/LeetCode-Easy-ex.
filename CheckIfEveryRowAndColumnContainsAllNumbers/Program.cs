using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfEveryRowAndColumnContainsAllNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix1 = new int[][]
            {
                new int[] {1,2,3},
                new int[] {3,1,2},
                new int[] {2,3,1},
            };

            var matrix2 = new int[][]
            {
                new int[] {1,1,1},
                new int[] {1,2,3},
                new int[] {1,2,3},
            };

            Console.WriteLine(CheckIfEveryRowAndColumnContainsAllNumbers(matrix1));
            Console.WriteLine(CheckIfEveryRowAndColumnContainsAllNumbers(matrix2));
        }

        public static bool CheckIfEveryRowAndColumnContainsAllNumbers(int[][] matrix)
        {
            int n = matrix.Length;
            var validNums = new List<int>();

            for (int i = 1; i <= n; i++)
                validNums.Add(i);

            var permValidNums = new List<int>(validNums);

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (validNums.Contains(matrix[row][col]))
                        validNums.Remove(matrix[row][col]);
                    else
                        return false;
                }

                validNums = new List<int>(permValidNums);
            }

            for (int col = 0; col < matrix.Length; col++)
            {
                for (int row = 0; row < matrix[col].Length; row++)
                {
                    if (validNums.Contains(matrix[row][col]))
                        validNums.Remove(matrix[row][col]);
                    else
                        return false;
                }

                validNums = new List<int>(permValidNums);
            }

            return true;
        }
    }
}
