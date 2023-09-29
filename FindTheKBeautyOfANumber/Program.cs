using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheKBeautyOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheKBeautyOfANumber(30003, 3));
            Console.WriteLine(FindTheKBeautyOfANumber(2, 1));
            Console.WriteLine(FindTheKBeautyOfANumber(430043, 2));
            Console.WriteLine(FindTheKBeautyOfANumber(240, 2));
        }

        public static int FindTheKBeautyOfANumber(int num, int k)
        {
            int counter = 0;
            var chNum = num.ToString().ToCharArray();

            if (chNum.Length == 1)
                return 1;

            for (int i = 0; i < chNum.Length - k + 1; i++)
            {
                var result = "";
                for (int j = i; j < i + k; j++)
                {
                    result += chNum[j] - 48;
                }

                var parsed = 0;
                if (result != "")
                    parsed = int.Parse(result);

                if (parsed != 0 && num % parsed == 0)
                    counter++;
            }
            return counter;
        }
    }
}
