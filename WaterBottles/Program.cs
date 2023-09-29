using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WaterBottles(9, 3));
            Console.WriteLine(WaterBottles(15, 4));
        }

        public static int WaterBottles(int numBottles, int numExchange)
        {
            var emptyBottles = 0;
            var sum = numBottles;
            emptyBottles = numBottles;

            while (emptyBottles >= numExchange)
            {
                var test = emptyBottles / numExchange;
                var bonusEmpty = emptyBottles % numExchange;
                emptyBottles /= numExchange;
                emptyBottles += bonusEmpty;

                sum += test;
            }

            return sum;
        }
    }
}
