using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternatingDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AlternatingDigitSum(521));
            Console.WriteLine(AlternatingDigitSum(111));
            Console.WriteLine(AlternatingDigitSum(886996));
        }

        public static int AlternatingDigitSum(int n)
        {
            var chNum = n.ToString().ToCharArray();
            var positiveSum = 0;
            var negativeSum = 0;

            for (int i = 0; i < chNum.Length; i += 2)
                positiveSum += chNum[i] - 48;
            for (int i = 1; i < chNum.Length; i += 2)
                negativeSum -= chNum[i] - 48;

            return positiveSum + negativeSum;
        }
    }
}
