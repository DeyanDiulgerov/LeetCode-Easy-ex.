using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountGoodTriplets
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine(CountGoodTriplets(new int[] { 3, 0, 1, 1, 9, 7 }, 7, 2, 3));
            Console.WriteLine(CountGoodTriplets(new int[] { 1, 1, 2, 2, 3 }, 0, 0, 1));
        }

        public static int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {

                        if (Math.Abs(arr[i] - arr[j]) <= a &&
                            Math.Abs(arr[j] - arr[k]) <= b &&
                            Math.Abs(arr[i] - arr[k]) <= c)
                            counter++;
                    }
                }
            }

            return counter;
        }
    }
}
