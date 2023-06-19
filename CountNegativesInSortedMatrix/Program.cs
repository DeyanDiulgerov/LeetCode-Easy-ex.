using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNegativesInSortedMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int CountNegativesInSortedMatrix(int[][] grid)
        {
            int counter = 0;

            foreach (var item in grid)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] < 0)
                        counter++;
                }
            }

            return counter;
        }
    }
}
