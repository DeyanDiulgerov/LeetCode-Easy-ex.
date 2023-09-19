using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfWordEqualsSummationOfTwoWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfWordEqualsSummationOfTwoWords("acb", "cba", "cdb"));
            Console.WriteLine(CheckIfWordEqualsSummationOfTwoWords("aaa", "a", "aab"));
            Console.WriteLine(CheckIfWordEqualsSummationOfTwoWords("aaa", "a", "aaaa"));
        }

        public static bool CheckIfWordEqualsSummationOfTwoWords(string firstWord, string secondWord, string targetWord)
        {
            var firstNum = 0;
            var secondNum = 0;
            var targetNum = 0;
            var stringTestOne = "";
            var stringTestTwo = "";
            var stringTestTarget = "";

            for (int i = 0; i < firstWord.Length; i++)
                stringTestOne += firstWord[i] - 97;

            firstNum = int.Parse(stringTestOne);

            for (int i = 0; i < secondWord.Length; i++)
                stringTestTwo += secondWord[i] - 97;

            secondNum = int.Parse(stringTestTwo);

            for (int i = 0; i < targetWord.Length; i++)
                stringTestTarget += targetWord[i] - 97;

            targetNum = int.Parse(stringTestTarget);

            if (firstNum + secondNum == targetNum)
                return true;
            else
                return false;
        }
    }
}
