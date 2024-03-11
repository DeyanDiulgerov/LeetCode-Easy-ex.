using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleRedistributionIntoBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AppleRedistributionIntoBoxes(new int[] { 1, 3, 2 }, new int[] { 4, 3, 1, 5, 2 }));
            Console.WriteLine(AppleRedistributionIntoBoxes(new int[] { 5, 5, 5 }, new int[] { 2, 4, 2, 7 }));
        }
        public static int AppleRedistributionIntoBoxes(int[] apple, int[] capacity)
        {
            Array.Sort(apple);
            Array.Sort(capacity);
            int left = apple.Length - 1;
            int counter = 0;
            for (int right = capacity.Length - 1; right >= 0; right--)
            {
                if (left < 0)
                    break;
                if (apple[left] == capacity[right])
                {
                    capacity[right] = 0;
                    apple[left] = 0;
                    left--;
                    counter++;
                }
                else if (apple[left] > capacity[right])
                {
                    apple[left] -= capacity[right];
                    counter++;
                }
                else//(apple[left] < capacity[right])
                {
                    while (left > 0 && capacity[right] > apple[left])
                    {
                        capacity[right] -= apple[left];
                        apple[left] = 0;
                        left--;
                    }
                    if (capacity[right] != 0 && left >= 0)
                    {
                        apple[left] -= capacity[right];
                        capacity[right] = 0;
                        if (apple[left] <= 0)
                        {
                            apple[left] = 0;
                            left--;
                        }
                    }
                    counter++;
                }
            }
            return counter;
        }
    }
}
