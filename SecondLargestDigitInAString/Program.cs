using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargestDigitInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SecondLargestDigitInAString("ck077"));
            Console.WriteLine(SecondLargestDigitInAString("dfa12321afd"));
            Console.WriteLine(SecondLargestDigitInAString("abc1111"));
        }

        public static int SecondLargestDigitInAString(string s)
        {
            var allDigitsList = new List<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                    allDigitsList.Add(s[i] - 48);
            }

            if (allDigitsList.All(x => x == allDigitsList.First()))
                return -1;

            allDigitsList.Sort();
            allDigitsList = allDigitsList.Distinct().ToList();
            var last = allDigitsList.Last();
            allDigitsList.Remove(last);
            var secondLast = allDigitsList.Last();
            return secondLast;
        }
    }
}
