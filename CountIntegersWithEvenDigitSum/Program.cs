using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountIntegersWithEvenDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountIntegersWithEvenDigitSum(30));
            Console.WriteLine(CountIntegersWithEvenDigitSum(4));
        }

        public static int CountIntegersWithEvenDigitSum(int num)
        {
            int counter = 0;

            for (int i = 2; i <= num; i++)
            {
                var chNum = i.ToString().ToCharArray();

                if (chNum.Length >= 2)
                {
                    var sum = 0;

                    for (int j = 0; j < chNum.Length; j++)
                        sum += chNum[j] - 48;

                    if (sum % 2 == 0)
                        counter++;
                }
                else
                {
                    if (i % 2 == 0)
                        counter++;
                }
            }
            return counter;
        }
    }
}
