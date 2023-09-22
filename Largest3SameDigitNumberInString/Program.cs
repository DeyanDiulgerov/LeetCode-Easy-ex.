using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3SameDigitNumberInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Largest3SameDigitNumberInString("74444"));
            Console.WriteLine(Largest3SameDigitNumberInString("1221000"));
            Console.WriteLine(Largest3SameDigitNumberInString("222"));
            Console.WriteLine(Largest3SameDigitNumberInString("6777133339"));
            Console.WriteLine(Largest3SameDigitNumberInString("2300019"));
            Console.WriteLine(Largest3SameDigitNumberInString("42352338"));
        }
        public static string Largest3SameDigitNumberInString(string num)
        {
            if (num.Length == 3 && num.All(x => x == num[0]))
                return num;

            var allNums = new List<int>();

            for (int i = 0; i < num.Length; i++)
            {
                int counter = 1;
                var newNum = "";
                newNum += num[i];

                while (i < num.Length - 1 && num[i] == num[i + 1] && counter <= 3 && newNum.Length < 3)
                {
                    newNum += num[i + 1];

                    counter++;
                    i++;
                }

                if (newNum.Length == 3)
                    allNums.Add(int.Parse(newNum));
            }

            allNums.Sort();
            if (allNums.Count() > 0 && allNums.Last() == 0)
                return "000";
            else if (allNums.Count() > 0)
                return allNums.Last().ToString();
            else
                return "";
        }
    }
}
