using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTestedDevicesAfterTestOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountTestedDevicesAfterTestOperations(new int[] { 1, 1, 2, 1, 3 }));
            Console.WriteLine(CountTestedDevicesAfterTestOperations(new int[] { 0, 1, 2 }));
        }
        public static int CountTestedDevicesAfterTestOperations(int[] batteryPercentages)
        {
            int count = 0;
            int n = batteryPercentages.Length;
            for (int i = 0; i < n; i++)
            {
                if (batteryPercentages[i] > 0)
                {
                    count++;
                    for (int j = i + 1; j < n; j++)
                    {
                        batteryPercentages[j] = Math.Max(0, batteryPercentages[j] - 1);
                    }
                }
            }
            return count;
        }
    }
}
