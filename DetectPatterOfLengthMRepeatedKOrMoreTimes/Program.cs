using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectPatterOfLengthMRepeatedKOrMoreTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DetectPatterOfLengthMRepeatedKOrMoreTimes(new int[]
            { 3, 1, 1, 3, 4, 2, 1, 4, 2, 4, 4, 2, 2, 2, 3, 4, 3, 1, 1, 1, 2 }, 2, 2));
            Console.WriteLine(DetectPatterOfLengthMRepeatedKOrMoreTimes(new int[] { 2, 2, 1, 2, 2, 1, 1, 1, 2, 1 }, 2, 2));
            Console.WriteLine(DetectPatterOfLengthMRepeatedKOrMoreTimes(new int[]
            { 3, 2, 1, 3, 3, 2, 1, 3, 3, 1, 2, 3, 3, 2, 1, 3, 2, 1, 1 }, 1, 2));
            Console.WriteLine(DetectPatterOfLengthMRepeatedKOrMoreTimes(new int[] { 1, 2, 2, 2, 1, 1, 2, 2, 2 }, 1, 3));
            Console.WriteLine(DetectPatterOfLengthMRepeatedKOrMoreTimes(new int[] { 3, 1, 2, 1, 2 }, 2, 2));
            Console.WriteLine(DetectPatterOfLengthMRepeatedKOrMoreTimes(new int[] { 1, 2, 3, 1, 2 }, 2, 2));
            Console.WriteLine(DetectPatterOfLengthMRepeatedKOrMoreTimes(new int[] { 1, 2, 1, 2, 3 }, 2, 2));
            Console.WriteLine(DetectPatterOfLengthMRepeatedKOrMoreTimes(new int[] { 1, 2, 4, 4, 4, 4 }, 1, 3));
            Console.WriteLine(DetectPatterOfLengthMRepeatedKOrMoreTimes(new int[] { 1, 2, 1, 2, 1, 1, 1, 3 }, 2, 2));
            Console.WriteLine(DetectPatterOfLengthMRepeatedKOrMoreTimes(new int[] { 1, 2, 1, 2, 1, 3 }, 2, 3));
        }

        public static bool DetectPatterOfLengthMRepeatedKOrMoreTimes(int[] arr, int m, int k)
        {
            int n = arr.Length;

            for (int i = 0; i < n - m; i++)
            {
                int j = i;
                while (j < n - m && arr[j] == arr[j + m])
                    j++;

                if ((j - i) / m + 1 >= k)
                    return true;
            }
            return false;
        }
    }
}
