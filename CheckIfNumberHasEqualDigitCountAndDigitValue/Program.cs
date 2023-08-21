using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfNumberHasEqualDigitCountAndDigitValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfNumberHasEqualDigitCountAndDigitValue("1210"));
            Console.WriteLine(CheckIfNumberHasEqualDigitCountAndDigitValue("030"));
        }

        public static bool CheckIfNumberHasEqualDigitCountAndDigitValue(string num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num.Where(x => int.Parse(x.ToString()) == i).Count() == num[i] - 48)
                {

                }
                else
                    return false;
            }

            return true;
        }
    }
}
