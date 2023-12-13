using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseKeyFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LicenseKeyFormatting("5F3Z-2e-9-w", 4));
            Console.WriteLine(LicenseKeyFormatting("2-5g-3-J", 2));
        }

        public static string LicenseKeyFormatting(string s, int k)
        {
            var alphaNumericStr = String.Concat(s.Split('-'));
            //Console.WriteLine(alphaNumericStr);

            string result = "";
            int counter = 0;
            for (int i = alphaNumericStr.Length - 1; i >= 0; i--)
            {
                //Console.WriteLine(alphaNumericStr);
                if (counter == k)
                {
                    result += '-';
                    counter = 0;
                }
                if (char.IsLetter(alphaNumericStr[i]))
                    result += alphaNumericStr[i].ToString().ToUpper();
                else
                    result += alphaNumericStr[i];
                counter++;
            }

            return String.Concat(result.Reverse());
        }
    }
}
