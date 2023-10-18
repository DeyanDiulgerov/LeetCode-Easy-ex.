using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeChange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LemonadeChange(new int[]
            { 5, 5, 10, 20, 5, 5, 5, 5, 5, 5, 5, 5, 5, 10, 5, 5, 20, 5, 20, 5 }));
            Console.WriteLine(LemonadeChange(new int[] { 5, 5, 5, 10, 20 }));
            Console.WriteLine(LemonadeChange(new int[] { 5, 5, 10, 10, 20 }));
        }

        public static bool LemonadeChange(int[] bills)
        {
            var moneyAndCountDict = new Dictionary<int, int>()
            {
                { 5, 0 },
                { 10, 0 },
                { 20, 0 },
            };

            for (int i = 0; i < bills.Length; i++)
            {
                if (bills[i] == 5)
                    moneyAndCountDict[5]++;
                else if (bills[i] == 10)
                {
                    moneyAndCountDict[10]++;

                    if (moneyAndCountDict[5] == 0)
                        return false;
                    else
                        moneyAndCountDict[5]--;
                }
                else if (bills[i] == 20)
                {
                    moneyAndCountDict[20]++;

                    if (moneyAndCountDict[5] > 0 && moneyAndCountDict[10] > 0)
                    {
                        moneyAndCountDict[5]--;
                        moneyAndCountDict[10]--;
                    }
                    else if (moneyAndCountDict[5] >= 3)
                        moneyAndCountDict[5] -= 3;
                    else
                        return false;
                }
            }
            return true;
        }
    }
}
