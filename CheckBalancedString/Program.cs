using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBalancedString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckBalancedString("1234"));
            Console.WriteLine(CheckBalancedString("24123"));
        }

        public static bool CheckBalancedString(string num)
        {
            int oddSum = 0, evenSum = 0;
            for (int i = 0; i < num.Length; i += 2)
            {
                evenSum += num[i] - 48;
                if (i + 1 >= num.Length)
                    break;
                oddSum += num[i + 1] - 48;
            }
            return evenSum == oddSum;
        }
    }
}
