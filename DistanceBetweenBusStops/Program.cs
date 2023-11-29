using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenBusStops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DistanceBetweenBusStops(
                new int[] { 7, 10, 1, 12, 11, 14, 5, 0 }, 7, 2));
            Console.WriteLine(DistanceBetweenBusStops(
                new int[] { 14, 13, 4, 7, 10, 17, 8, 3, 2, 13 }, 2, 9));
            Console.WriteLine(DistanceBetweenBusStops(new int[] { 1, 2, 3, 4 }, 0, 1));
            Console.WriteLine(DistanceBetweenBusStops(new int[] { 1, 2, 3, 4 }, 0, 2));
            Console.WriteLine(DistanceBetweenBusStops(new int[] { 1, 2, 3, 4 }, 0, 3));
        }
        public static int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            int leftDistance = 0, rightDistance = 0;
            int n = distance.Length;

            for (int r = start; r < n; r++)
            {
                if (r == destination)
                    break;
                else if (r == n - 1)
                {
                    rightDistance += distance[r];
                    r = 0;
                    r--;
                }
                else
                    rightDistance += distance[r];
            }
            for (int l = start; l >= 0; l--)
            {
                if (l == destination)
                    break;
                else if (l == 0)
                {
                    l = n - 1;
                    leftDistance += distance[l];
                    l++;
                }
                else
                    leftDistance += distance[l - 1];
            }
            return Math.Min(leftDistance, rightDistance);
        }
    }
}
