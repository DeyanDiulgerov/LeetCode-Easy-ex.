using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDelayedArrivalTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateDelayedArrivalTime(23, 22));
            Console.WriteLine(CalculateDelayedArrivalTime(22, 18));
            Console.WriteLine(CalculateDelayedArrivalTime(15, 5));
            Console.WriteLine(CalculateDelayedArrivalTime(13, 11));
        }

        public static int CalculateDelayedArrivalTime(int arrivalTime, int delayedTime)
        {
            var sum = arrivalTime + delayedTime;

            if (sum > 24)
                return sum - 24;
            else
                return sum;
        }
    }
}
