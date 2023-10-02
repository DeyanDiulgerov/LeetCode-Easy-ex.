using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalanceAfterRoundedPurchase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AccountBalanceAfterRoundedPurchase(100));
            Console.WriteLine(AccountBalanceAfterRoundedPurchase(9));
            Console.WriteLine(AccountBalanceAfterRoundedPurchase(15));
        }

        public static int AccountBalanceAfterRoundedPurchase(int purchaseAmount)
        {
            if (purchaseAmount == 100)
                return 0;
            if (purchaseAmount.ToString().Length == 1)
            {
                if (purchaseAmount <= 4)
                    return 100;

                return 90;
            }

            var chN = purchaseAmount.ToString();
            var remover = chN[0] - 48;

            var num1 = "";
            var num2 = "";
            num1 += remover; num1 += '0';
            num2 += remover + 1; num2 += '0';

            var parsed1 = int.Parse(num1);
            var parsed2 = int.Parse(num2);

            if (chN[1] - 48 <= 4)
                return 100 - parsed1;

            return 100 - parsed2;

        }
    }
}
