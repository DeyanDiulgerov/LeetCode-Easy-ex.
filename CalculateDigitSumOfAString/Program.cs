using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDigitSumOfAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateDigitSumOfAString("11111222223", 3));
            Console.WriteLine(CalculateDigitSumOfAString("00000000", 3));
        }

        public static string CalculateDigitSumOfAString(string s, int k)
        {
            while (s.Length > k)
            {
                var newS = "";
                int counter = 0;
                for (int i = 0; i < s.Length; i += counter)
                {
                    counter = 0;
                    var newText = "";

                    if (i + k < s.Length)
                        for (int j = i; j < i + k; j++)
                            newText += s[j];
                    else
                        for (int j = i; j < s.Length; j++)
                            newText += s[j];

                    int num = 0;
                    for (int l = 0; l < newText.Length; l++)
                    {
                        counter++;
                        num += (int)newText[l] - 48;
                    }

                    newS += num.ToString();
                }

                s = newS;
            }

            return s;
        }
    }
}
