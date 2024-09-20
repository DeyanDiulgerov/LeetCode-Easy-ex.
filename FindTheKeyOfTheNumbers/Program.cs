using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheKeyOfTheNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheKeyOfTheNumbers(1, 10, 1000));
            Console.WriteLine(FindTheKeyOfTheNumbers(987, 879, 798));
            Console.WriteLine(FindTheKeyOfTheNumbers(1, 2, 3));
        }

        public static int FindTheKeyOfTheNumbers(int num1, int num2, int num3)
        {
            string strNum1 = PadNumber(num1.ToString());
            string strNum2 = PadNumber(num2.ToString());
            string strNum3 = PadNumber(num3.ToString());
            string result = "";

            for (int i = 0; i < 4; i++)
            {
                int firstMin = Math.Min(strNum1[i] - 48, strNum2[i] - 48);
                int min = Math.Min(firstMin, strNum3[i] - 48);

                result += min.ToString();
            }

            string PadNumber(string str)
            {
                int n = 4 - str.Length;
                while (n > 0)
                {
                    str = str.Insert(0, "0");
                    n--;
                }
                return str;
            }

            return int.Parse(result);
        }
    }
}
