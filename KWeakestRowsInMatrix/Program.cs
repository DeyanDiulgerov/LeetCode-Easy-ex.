using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWeakestRowsInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var mat3 = new int[][]
            {
                new int[] {1,0},
                new int[] {1,0},
                new int[] {1,0},
                new int[] {1,1},
            };

            var mat1 = new int[][]
            {
                new int[] {1,1,0,0,0},
                new int[] {1,1,1,1,0},
                new int[] {1,0,0,0,0},
                new int[] {1,1,0,0,0},
                new int[] {1,1,1,1,1},
            };

            var mat2 = new int[][]
            {
                new int[] {1,0,0,0},
                new int[] {1,1,1,1},
                new int[] {1,0,0,0},
                new int[] {1,0,0,0},
            };

            Console.WriteLine(String.Join(",", KWeakestRowsInMatrix(mat3, 4)));
            Console.WriteLine(String.Join(",", KWeakestRowsInMatrix(mat1, 3)));
            Console.WriteLine(String.Join(",", KWeakestRowsInMatrix(mat2, 2)));
        }

        public static int[] KWeakestRowsInMatrix(int[][] mat, int k)
        {
            int soldiers = 0;
            var dictionary = new Dictionary<int, int>();
            var retList = new List<int>();

            for (int i = 0; i < mat.Length; i++)
            {
                soldiers = 0;

                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 1)
                        soldiers++;
                }

                dictionary.Add(i, soldiers);
            }

            int counter = 0;
            foreach (var kvp in dictionary.OrderBy(x => x.Value))
            {
                retList.Add(kvp.Key);
                counter++;
                if (counter >= k)
                    break;
            }

            return retList.ToArray();
        }
    }
}
