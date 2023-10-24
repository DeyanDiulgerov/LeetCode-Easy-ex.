using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigitsOfStringAfterConvert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfDigitsOfStringAfterConvert("iiii", 1));
            Console.WriteLine(SumOfDigitsOfStringAfterConvert("leetcode", 2));
            Console.WriteLine(SumOfDigitsOfStringAfterConvert("zbax", 10));
        }
        public static int SumOfDigitsOfStringAfterConvert(string s, int k)
        {
            var newStr = "";
            var result = 0;

            for (int i = 0; i < k; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < s.Length; j++)
                        newStr += s[j] - 96;

                    for (int l = 0; l < newStr.Length; l++)
                        result += newStr[l] - 48;
                }
                else
                {
                    newStr = result.ToString();
                    result = 0;

                    for (int m = 0; m < newStr.Length; m++)
                        result += newStr[m] - 48;
                }
            }

            return result;
        }
    }
}
