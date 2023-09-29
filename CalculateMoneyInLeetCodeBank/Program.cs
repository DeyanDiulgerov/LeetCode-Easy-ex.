using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateMoneyInLeetCodeBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateMoneyInLeetCodeBank(4));
            Console.WriteLine(CalculateMoneyInLeetCodeBank(10));
            Console.WriteLine(CalculateMoneyInLeetCodeBank(20));
        }

        public static int CalculateMoneyInLeetCodeBank(int n)
        {
            int mondayCounter = 1;
            int counter = 1;
            int sum = 0;
            bool isReset = false;

            for (int i = 0; i < n; i++)
            {
                if (isReset)
                {
                    counter = mondayCounter + 1;
                    isReset = false;
                }
                if (i % 7 == 0 && i != 0)
                {
                    mondayCounter++;
                    sum += mondayCounter;
                    isReset = true;
                    continue;
                }

                sum += counter;
                counter++;
            }
            return sum;
        }
    }
}
