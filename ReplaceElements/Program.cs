using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", ReplaceElements(new int[] { 17, 18, 5, 4, 6, 1 })));
            Console.WriteLine(String.Join(",", ReplaceElements(new int[] { 400 })));
        }

        public static int[] ReplaceElements(int[] arr)
        {
            int max = -1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int newMax = Math.Max(max, arr[i]);
                arr[i] = max;
                max = newMax;
            }

            return arr;
        }
    }
}
