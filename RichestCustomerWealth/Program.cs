using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichestCustomerWealth
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] account1 = new int[][]
            {
                new int[] {1,2,3},
                new int[] {3,2,1}
            };
            Console.WriteLine(MaximumWealth(account1));

            int[][] account2 = new int[][]
            {
                new int[] {1,5 },
                new int[] {7,3 },
                new int[] {3,5}
            };
            Console.WriteLine(MaximumWealth(account2));

            int[][] account3 = new int[][]
            {
                new int[] {2,8,7 },
                new int[] {7,1,3},
                new int[] {1,9,5}
            };
            Console.WriteLine(MaximumWealth(account3));
        }

        public static int MaximumWealth(int[][] accounts)
        {
            var sum = 0;
            var maxWealth = 0;

            foreach (var item in accounts)
            {
                sum = 0;
                for (int i = 0; i < item.Length; i++)
                {
                    sum += item[i];

                    maxWealth = Math.Max(sum, maxWealth);
                }
            }

            return maxWealth;
        }
    }
}
