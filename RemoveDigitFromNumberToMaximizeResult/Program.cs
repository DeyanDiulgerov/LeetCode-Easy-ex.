using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDigitFromNumberToMaximizeResult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveDigitFromNumberToMaximizeResult("3619552534", '5'));
            Console.WriteLine(RemoveDigitFromNumberToMaximizeResult("2998589353917872714814599237" +
                "991174513476623756395992135212546127959342974628712329595771672911914471", '3'));
            Console.WriteLine(RemoveDigitFromNumberToMaximizeResult("123", '3'));
            Console.WriteLine(RemoveDigitFromNumberToMaximizeResult("1231", '1'));
            Console.WriteLine(RemoveDigitFromNumberToMaximizeResult("551", '5'));
        }
        public static string RemoveDigitFromNumberToMaximizeResult(string number, char digit)
        {
            var allNums = new List<string>();

            for (int i = 0; i < number.Length; i++)
                if (number[i] == digit)
                    allNums.Add(number.Remove(i, 1));

            return allNums.Max();
        }
    }
}
