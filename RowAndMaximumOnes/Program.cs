using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowAndMaximumOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mat1 = new int[][]
            {
                new int[] {0,1},
                new int[] {1,0}
            };

            int[][] mat2 = new int[][]
            {
                new int[] {0,0,0},
                new int[] {0,1,1}
            };

            int[][] mat3 = new int[][]
            {
                new int[] {0,0},
                new int[] {1,1},
                new int[] {0,0}
            };

            Console.WriteLine(String.Join(",", RowAndMaximumOnes(mat1)));
            Console.WriteLine(String.Join(",", RowAndMaximumOnes(mat2)));
            Console.WriteLine(String.Join(",", RowAndMaximumOnes(mat3)));
        }

        public static int[] RowAndMaximumOnes(int[][] mat)
        {
            int maxOnes = 0;
            int returnRow = 0;

            for (int i = 0; i < mat.Length; i++)
            {
                var onesCounter = 0;

                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 1)
                        onesCounter++;
                }

                if (onesCounter > maxOnes)
                {
                    returnRow = i;
                    maxOnes = onesCounter;
                }
            }

            return new int[] { returnRow, maxOnes };
        }
    }
}
