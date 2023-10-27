using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialPositionInABinaryMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mat1 = new int[][]
            {
                new int[] {1,0,0},
                new int[] {0,0,1},
                new int[] {1,0,0}
            };
            var mat2 = new int[][]
            {
                new int[] {1,0,0},
                new int[] {0,1,0},
                new int[] {0,0,1}
            };

            Console.WriteLine(SpecialPositionInABinaryMatrix(mat1));
            Console.WriteLine(SpecialPositionInABinaryMatrix(mat2));
        }
        public static int SpecialPositionInABinaryMatrix(int[][] mat)
        {
            int result = 0;

            for (int row = 0; row < mat.Length; row++)
            {
                for (int col = 0; col < mat[row].Length; col++)
                {
                    bool isSpecial = true;

                    if (mat[row][col] == 1)
                    {
                        for (int i = row + 1; i < mat.Length; i++)
                            if (mat[i][col] == 1)
                                isSpecial = false;
                        for (int i = row - 1; i >= 0; i--) //1,0,0
                            if (mat[i][col] == 1)          //0,0,1
                                isSpecial = false;         //1,0,0
                        for (int i = col + 1; i < mat[row].Length; i++)
                            if (mat[row][i] == 1)
                                isSpecial = false;
                        for (int i = col - 1; i >= 0; i--)
                            if (mat[row][i] == 1)
                                isSpecial = false;
                    }

                    if (isSpecial && mat[row][col] == 1)
                        result++;
                }
            }

            return result;
        }
    }
}
