using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestTimeToBuyAndSellStock
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = new int[] { 7, 1, 5, 3, 6, 4 };
            var input2 = new int[] { 7, 6, 4, 3, 1 };
            var input3 = new int[] { 1, 1, 5, 3, 7, 4 };
            var input7 = new int[] { 1, 2 };
            var input5 = new int[] { 2 };
            var input6 = new int[] { 2, 1, 3 };
            var input4 = new int[] { 2, 4, 1 };


            Console.WriteLine(MaxProfit(input1));
            Console.WriteLine(MaxProfit(input2));
            Console.WriteLine(MaxProfit(input3));
            Console.WriteLine(MaxProfit(input4));
            Console.WriteLine(MaxProfit(input4));
            Console.WriteLine(MaxProfit(input5));
            Console.WriteLine(MaxProfit(input7));
        }

        public static int MaxProfit(int[] prices)
        {
            //prices[i] == price of given stock on the 1st day
            //MAX profit buy choosing best day to buy and another to sell
            //go through prices see first lowest to buy than after the highest price to sell

            int max = 0;
            int min = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }
                else if ((prices[i] - min) > max)
                {
                    max = prices[i] - min;
                }
            }
            return max;
        }
    }
}
