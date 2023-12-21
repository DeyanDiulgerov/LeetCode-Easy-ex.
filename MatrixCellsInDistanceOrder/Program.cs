using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCellsInDistanceOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            foreach (var item in MatrixCellsInDistanceOrder(1, 2, 0, 0))
                Console.Write(String.Join(",", item) + " ");
            Console.WriteLine("\n$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            foreach (var item in MatrixCellsInDistanceOrder(2, 2, 0, 1))
                Console.Write(String.Join(",", item) + " ");
            Console.WriteLine("\n$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            foreach (var item in MatrixCellsInDistanceOrder(2, 3, 1, 2))
                Console.Write(String.Join(",", item) + " ");
            Console.WriteLine("\n$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        }

        public static int[][] MatrixCellsInDistanceOrder(int rows, int cols, int rCenter, int cCenter)
        {
            Dictionary<int[], int> coordinatesAndDistanceMap = new Dictionary<int[], int>();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int[] newArr = new int[2];
                    newArr[0] = row;
                    newArr[1] = col;
                    int rowDistance = Math.Abs(rCenter - row);
                    int colDistance = Math.Abs(cCenter - col);
                    coordinatesAndDistanceMap.Add(newArr, rowDistance + colDistance);
                }
            }

            int n = coordinatesAndDistanceMap.Count();
            int[][] resultArr = new int[n][];
            int indexCount = 0;
            foreach (var kvp in coordinatesAndDistanceMap.OrderBy(x => x.Value))
            {
                resultArr[indexCount] = kvp.Key;
                indexCount++;
            }
            return resultArr;
        }
    }
}
