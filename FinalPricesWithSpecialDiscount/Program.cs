using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPricesWithSpecialDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FinalPricesWithSpecialDiscount(new int[] { 8, 4, 6, 2, 3 })));
            Console.WriteLine(String.Join(",", FinalPricesWithSpecialDiscount(new int[] { 1, 2, 3, 4, 5 })));
            Console.WriteLine(String.Join(",", FinalPricesWithSpecialDiscount(new int[] { 10, 1, 1, 6 })));
        }

        public static int[] FinalPricesWithSpecialDiscount(int[] prices)
        {
            int[] result = new int[prices.Length];

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[i] >= prices[j])
                    {
                        result[i] = prices[i] - prices[j];
                        break;
                    }
                    else
                        result[i] = prices[i];
                }
            }
            result[prices.Length - 1] = prices[prices.Length - 1];
            return result;
        }
    }
}
