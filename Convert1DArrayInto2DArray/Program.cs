using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert1DArrayInto2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Convert1DArrayInto2DArray(new int[] { 1, 3, 3, 5 }, 3, 1))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in Convert1DArrayInto2DArray(new int[] {3 }, 1, 2))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in Convert1DArrayInto2DArray(new int[] { 1, 2, 3, 4 }, 2, 2))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in Convert1DArrayInto2DArray(new int[] { 1, 2, 3 }, 1, 3))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in Convert1DArrayInto2DArray(new int[] { 1, 2 }, 1, 1))
                Console.WriteLine(String.Join(",", item));
        }
        public static int[][] Convert1DArrayInto2DArray(int[] original, int m, int n)
        {
            if (m == 1 && n == 1 && original.Length > 1)
                return new int[][] { };
            else if (m * n > original.Length || m * n < original.Length)
                return new int[][] { };

            int indexCount = 0;
            var resultMatrix = new int[m][];

            for (int i = 0; i < m; i++)
            {
                var newArr = new int[n];
                for (int j = 0; j < n; j++)
                {
                    newArr[j] = original[indexCount];
                    indexCount++;
                }
                resultMatrix[i] = newArr;
            }
            return resultMatrix;
        }
    }
}
