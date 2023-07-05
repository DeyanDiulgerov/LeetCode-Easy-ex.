using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimMeanOfArrayAfterRemovingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TrimMeanOfArrayAfterRemovingElements(new int[] { 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 }));
            Console.WriteLine(TrimMeanOfArrayAfterRemovingElements(new int[] { 6, 2, 7, 5, 1, 2, 0, 3, 10, 2, 5, 0, 5, 5, 0, 8, 7, 6, 8, 0 }));
            Console.WriteLine(TrimMeanOfArrayAfterRemovingElements(new int[] { 6, 0, 7, 0, 7, 5, 7, 8, 3, 4, 0, 7, 8, 1, 6, 8, 1, 1, 2, 4, 8, 1, 9, 5, 4, 3, 8, 5, 10, 8, 6, 6, 1, 0, 6, 10, 8, 2, 3, 4 }));
        }

        public static double TrimMeanOfArrayAfterRemovingElements(int[] arr)
        {
            var sorted = new List<double>();
            foreach (var num in arr)
                sorted.Add(num);

            sorted.Sort();

            double count = (arr.Length * 5) / 100;

            sorted.RemoveRange((int)(arr.Length - count), (int)count);
            sorted.RemoveRange(0, (int)count);

            double result = sorted.Sum() / sorted.Count();
            return Math.Round(result, 5);
        }
    }
}
