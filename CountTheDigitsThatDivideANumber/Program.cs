using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheDigitsThatDivideANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountTheDigitsThatDivideANumber(7));
            Console.WriteLine(CountTheDigitsThatDivideANumber(121));
            Console.WriteLine(CountTheDigitsThatDivideANumber(1248));
        }

        public static int CountTheDigitsThatDivideANumber(int num)
        {
            var charNum = num.ToString().ToCharArray();
            var allNums = new List<int>();
            foreach (var numm in charNum)
                allNums.Add(numm);

            var usedNums = new List<int>();
            int counter = 0;

            for (int i = 0; i < allNums.Count(); i++)
            {
                if (num % (allNums[i] - 48) == 0 && !usedNums.Contains(allNums[i] - 48))
                {
                    counter++;
                    usedNums.Add(allNums[i]);
                }
            }

            return counter;
        }
    }
}
