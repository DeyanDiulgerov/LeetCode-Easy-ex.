using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddDigits(5));
            Console.WriteLine(AddDigits(2));
            Console.WriteLine(AddDigits(1));
            Console.WriteLine(AddDigits(38));
            Console.WriteLine(AddDigits(0));
        }

        public static int AddDigits(int num)
        {
            var chNum = num.ToString().ToCharArray();
            if (chNum.Length == 1)
                return num;

            var sum = 0;
            while (chNum.Length > 1)
            {
                sum = 0;

                for (int i = 0; i < chNum.Length; i++)
                    sum += chNum[i] - 48;

                chNum = sum.ToString().ToCharArray();
            }

            return sum;
        }
    }
}
