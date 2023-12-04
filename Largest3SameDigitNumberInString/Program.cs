using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3SameDigitNumberInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Largest3SameDigitNumberInString("6777133339"));
            Console.WriteLine(Largest3SameDigitNumberInString("2300019"));
            Console.WriteLine(Largest3SameDigitNumberInString("42352338"));
        }

        public static string Largest3SameDigitNumberInString(string num)
        {
            var allGoodNums = new List<string>();
            int left = 0, right = 2;
            var substring = "";
            substring += num[left];
            substring += num[1];
            substring += num[right];
            if (substring.All(x => x == substring[0]))
                allGoodNums.Add(substring);

            while (right < num.Length - 1)
            {
                substring = substring.Remove(0, 1);
                right++;
                substring += num[right];
                if (substring.All(x => x == substring[0]))
                    allGoodNums.Add(substring);
            }
            return allGoodNums.Count() == 0 ? "" : allGoodNums.Max();
        }
    }
}
