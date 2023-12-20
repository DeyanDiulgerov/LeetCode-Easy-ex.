using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeAdditionII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ops1 = new int[][]
            {
                new int[] {2,2},
                new int[] {3,3},
            };
            var ops2 = new int[][]
           {
                new int[] {2,2},
                new int[] {3,3},
                new int[] {3,3},
                new int[] {3,3},
                new int[] {2,2},
                new int[] {3,3},
                new int[] {3,3},
                new int[] {3,3},
                new int[] {2,2},
                new int[] {3,3},
                new int[] {3,3},
                new int[] {3,3},
           };
            var ops3 = new int[][]
            {

            };

            Console.WriteLine(RangeAdditionII(3, 3, ops1));
            Console.WriteLine(RangeAdditionII(3, 3, ops2));
            Console.WriteLine(RangeAdditionII(3, 3, ops3));
        }

        public static int RangeAdditionII(int m, int n, int[][] ops)
        {
            // "Count and return the number of cells in the matrix that
            // would be impacted by every operation in the ops list."
            int minRow = m;
            int minCol = n;
            for (int i = 0; i < ops.Length; i++)
            {
                if (ops[i][0] < minRow)
                    minRow = ops[i][0];
                if (ops[i][1] < minCol)
                    minCol = ops[i][1];
            }
            return minRow * minCol;
        }
    }
}
