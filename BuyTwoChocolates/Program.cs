using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyTwoChocolates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BuyTwoChocolates(new int[] { 1, 2, 2 }, 3));
            Console.WriteLine(BuyTwoChocolates(new int[] { 3, 2, 3 }, 3));
        }

        public static int BuyTwoChocolates(int[] prices, int money)
        {
            var listed = new List<int>(prices);
            int minChoco = listed.Min();
            listed.Remove(minChoco);
            int secondMinChoco = listed.Min();
            var allChocos = minChoco + secondMinChoco;

            if (money >= allChocos)
                return money - allChocos;
            else
                return money;
        }
    }
}
