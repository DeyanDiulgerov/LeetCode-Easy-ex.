using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheDistanceValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheDistanceValue(new int[] { 4, 5, 8 }, new int[] { 10, 9, 1, 8 }, 2));
            Console.WriteLine(FindTheDistanceValue(new int[] { 1, 4, 2, 3 }, new int[] { -4, -3, 6, 10, 20, 30 }, 3));
            Console.WriteLine(FindTheDistanceValue(new int[] { 2, 1, 100, 3 }, new int[] { -5, -2, 10, -3, 7 }, 6));
        }

        public static int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            int counter = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                bool isValid = true;

                for (int j = 0; j < arr2.Length; j++)
                {
                    int distance = 0;

                    if (arr1[i] > arr2[j])
                        distance = arr1[i] - arr2[j];
                    else
                        distance = arr2[j] - arr1[i];

                    if (distance <= d)
                        isValid = false;
                }
                if (isValid)
                    counter++;
            }

            return counter;
        }
    }
}
