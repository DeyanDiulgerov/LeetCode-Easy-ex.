using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDevisorOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GreatestCommonDevisorOfStrings("TAUXXTAUXXTAUXXTAUXXTAUXX", "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX"));
            Console.WriteLine(GreatestCommonDevisorOfStrings("ABCABC", "ABC"));
            Console.WriteLine(GreatestCommonDevisorOfStrings("ABABAB", "ABAB"));
            Console.WriteLine(GreatestCommonDevisorOfStrings("LEET", "CODE"));
        }
        public static string GreatestCommonDevisorOfStrings(string str1, string str2)
        {
            if (str1.Length == 0 || str2.Length == 0
             || str1 + str2 != str2 + str1)
                return "";

            int shortest = str1.Length;
            int prevRemainder = str2.Length;
            int remainder = shortest % prevRemainder;
            while (remainder != 0)
            {
                shortest = prevRemainder;
                prevRemainder = remainder;
                remainder = shortest % prevRemainder;
            }
            return str1.Substring(0, prevRemainder);
        }
    }
}
