using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSumOfFourDigitNumberAfterSplittingDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumSumOfFourDigitNumberAfterSplittingDigits(2932));
            Console.WriteLine(MinimumSumOfFourDigitNumberAfterSplittingDigits(4009));
        }

        public static int MinimumSumOfFourDigitNumberAfterSplittingDigits(int num)
        {
            var charNum = num.ToString().ToCharArray();
            var listed = new List<char>(charNum);
            listed.Sort();

            var firstNum = "";
            var secondNum = "";

            firstNum += listed[0];
            secondNum += listed[1];
            firstNum += listed[2];
            secondNum += listed[3];

            return int.Parse(firstNum) + int.Parse(secondNum);
        }
    }
}
