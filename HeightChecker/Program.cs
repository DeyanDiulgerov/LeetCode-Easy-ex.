using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HeightChecker(new int[] { 1, 1, 4, 2, 1, 3 }));
            Console.WriteLine(HeightChecker(new int[] { 5, 1, 2, 3, 4 }));
        }

        public static int HeightChecker(int[] heights)
        {
            var expectedHeights = new List<int>(heights);
            expectedHeights.Sort();

            int counter = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != expectedHeights[i])
                    counter++;
            }

            return counter;
        }
    }
}
