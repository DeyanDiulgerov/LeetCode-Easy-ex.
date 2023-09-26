using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finding3DigitEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", Finding3DigitEvenNumbers(new int[] { 2, 1, 3, 0 })));
            Console.WriteLine(String.Join(",", Finding3DigitEvenNumbers(new int[] { 2, 2, 8, 8, 2 })));
            Console.WriteLine(String.Join(",", Finding3DigitEvenNumbers(new int[] { 3, 7, 5 })));
        }

        public static int[] Finding3DigitEvenNumbers(int[] digits)
        {
            var allNums = new List<int>();

            for (int i = 0; i < digits.Length; i++)
            {
                for (int j = i + 1; j < digits.Length; j++)
                {
                    for (int k = j + 1; k < digits.Length; k++)
                    {
                        var summedSrt = "";
                        summedSrt += digits[i];
                        summedSrt += digits[j];
                        summedSrt += digits[k];

                        var parsed = int.Parse(summedSrt);
                        if (parsed % 2 == 0 && parsed.ToString().Length == 3)
                            allNums.Add(parsed);

                        summedSrt = "";
                        summedSrt += digits[i];
                        summedSrt += digits[k];
                        summedSrt += digits[j];

                        parsed = int.Parse(summedSrt);
                        if (parsed % 2 == 0 && parsed.ToString().Length == 3)
                            allNums.Add(parsed);

                        summedSrt = "";
                        summedSrt += digits[j];
                        summedSrt += digits[i];
                        summedSrt += digits[k];

                        parsed = int.Parse(summedSrt);
                        if (parsed % 2 == 0 && parsed.ToString().Length == 3)
                            allNums.Add(parsed);

                        summedSrt = "";
                        summedSrt += digits[k];
                        summedSrt += digits[i];
                        summedSrt += digits[j];

                        parsed = int.Parse(summedSrt);
                        if (parsed % 2 == 0 && parsed.ToString().Length == 3)
                            allNums.Add(parsed);

                        summedSrt = "";
                        summedSrt += digits[k];
                        summedSrt += digits[j];
                        summedSrt += digits[i];

                        parsed = int.Parse(summedSrt);
                        if (parsed % 2 == 0 && parsed.ToString().Length == 3)
                            allNums.Add(parsed);

                        summedSrt = "";
                        summedSrt += digits[j];
                        summedSrt += digits[k];
                        summedSrt += digits[i];

                        parsed = int.Parse(summedSrt);
                        if (parsed % 2 == 0 && parsed.ToString().Length == 3)
                            allNums.Add(parsed);
                    }
                }
            }
            allNums.Sort();
            return allNums.Distinct().ToArray();
        }
    }
}
