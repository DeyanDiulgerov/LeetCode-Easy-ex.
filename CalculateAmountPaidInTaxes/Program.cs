using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAmountPaidInTaxes
{
    class Program
    {
        static void Main(string[] args)
        {
            var brackets1 = new int[][]
            {
                new int[] {3,50},
                new int[] {7,10},
                new int[] {12,25},
            };

            var brackets2 = new int[][]
            {
                new int[] {1,0},
                new int[] {4,25},
                new int[] {5,50},
            };

            var brackets3 = new int[][]
            {
                new int[] {2,50},
            };

            Console.WriteLine(CalculateAmountPaidInTaxes(brackets1, 10));
            Console.WriteLine(CalculateAmountPaidInTaxes(brackets2, 2));
            Console.WriteLine(CalculateAmountPaidInTaxes(brackets3, 0));
        }

        public static double CalculateAmountPaidInTaxes(int[][] brackets, int income)
        {
            double tax = 0.0;
            for (int i = 0, prevUpper = 0; i < brackets.Length; i++)
            {
                int amount = Math.Min(brackets[i][0] - prevUpper, income);
                tax += (amount * brackets[i][1]) / 100.0;

                income -= amount;
                if (income <= 0)
                    break;
                prevUpper = brackets[i][0];
            }

            return tax;
        }
    }
}
