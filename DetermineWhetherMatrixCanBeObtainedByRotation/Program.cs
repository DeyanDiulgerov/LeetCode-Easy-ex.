using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetermineWhetherMatrixCanBeObtainedByRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mat1 = new int[][]
            {
                new int[] {0, 1},
                new int[] {1, 0},
            };
            var target1 = new int[][]
            {
                new int[] {1, 0},
                new int[] {0, 1},
            };
            var mat2 = new int[][]
            {
                new int[] {0, 1},
                new int[] {1, 1},
            };
            var target2 = new int[][]
            {
                new int[] {1, 0},
                new int[] {0, 1},
            };
            var mat3 = new int[][]
            {
                new int[] {0,0,0},
                new int[] {0,1,0},
                new int[] {1,1,1},
            };
            var target3 = new int[][]
            {
                new int[] {1,1,1},
                new int[] {0,1,0},
                new int[] {0,0,0},
            };
            Console.WriteLine(DetermineWhetherMatrixCanBeObtainedByRotation(mat1, target1));
            Console.WriteLine(DetermineWhetherMatrixCanBeObtainedByRotation(mat2, target2));
            Console.WriteLine(DetermineWhetherMatrixCanBeObtainedByRotation(mat3, target3));
        }
        public static bool DetermineWhetherMatrixCanBeObtainedByRotation(int[][] mat, int[][] target)
        {
            int n = mat.Length;

            for (int i = 0; i < 4; i++)
            {
                var newMatrix = new int[n][];

                for (int row = 0; row < n; row++)
                {
                    var newArr = new int[n];
                    int indexCount = 0;
                    for (int col = n - 1; col >= 0; col--)
                    {
                        newArr[indexCount] = mat[col][row];
                        indexCount++;
                    }
                    newMatrix[row] = newArr;
                }
                bool areEqual = true;
                for (int j = 0; j < mat.Length; j++)
                {
                    if (!target[j].SequenceEqual(newMatrix[j]))
                    {
                        areEqual = false;
                        break;
                    }
                }
                if (areEqual)
                    return true;

                mat = newMatrix;
            }
            return false;
        }
    }
}
