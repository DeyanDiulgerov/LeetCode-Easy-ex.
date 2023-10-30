using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanPlaceFlowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanPlaceFlowers(new int[] { 0 }, 0));
            Console.WriteLine(CanPlaceFlowers(new int[] { 0, 0 }, 2));
            Console.WriteLine(CanPlaceFlowers(new int[] { 1, 0, 0, 0, 0, 1 }, 2));
            Console.WriteLine(CanPlaceFlowers(new int[] { 0, 1, 0, 1, 0, 1, 0, 0 }, 1));
            Console.WriteLine(CanPlaceFlowers(new int[] { 0, 0, 1, 0, 1 }, 1));
            Console.WriteLine(CanPlaceFlowers(new int[] { 0, 1, 0 }, 1));
            Console.WriteLine(CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1, 0, 0 }, 2));
            Console.WriteLine(CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 1));
            Console.WriteLine(CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 2));
        }

        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            if (flowerbed.Length == 1 && n == 1 && flowerbed[0] == 0)
                return true;
            else if (flowerbed.Length == 1 && n == 1 && flowerbed[0] == 1)
                return false;
            else if (flowerbed.Length == 1)
                return true;

            int newI = 0;
            int counter = 0;

            if (flowerbed[0] == 1)
                newI = 1;

            for (int i = newI; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 1)
                    continue;

                if (i == flowerbed.Length - 1)
                {
                    if (flowerbed[i] == 0 && flowerbed[i - 1] == 0)
                        counter++;
                    break;
                }
                else if (i == 0)
                {
                    if (flowerbed[i] == 0 && flowerbed[i + 1] == 0)
                        counter++;

                    flowerbed[i] = 1;
                    continue;
                }

                if (flowerbed[i] == 0 && flowerbed[i + 1] == 0 && flowerbed[i - 1] == 0)
                {
                    counter++;
                    flowerbed[i] = 1;
                }
            }

            if (counter >= n)
                return true;
            else
                return false;
        }
    }
}
