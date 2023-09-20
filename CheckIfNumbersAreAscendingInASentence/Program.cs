using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfNumbersAreAscendingInASentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfNumbersAreAscendingInASentence("1 3 4 6 12 yy"));
            Console.WriteLine(CheckIfNumbersAreAscendingInASentence("5 x 5"));
            Console.WriteLine(CheckIfNumbersAreAscendingInASentence("7 51 50 60"));
            Console.WriteLine(CheckIfNumbersAreAscendingInASentence("1 box has 3 blue 4 red 6 green and 12 yellow marbles"));
            Console.WriteLine(CheckIfNumbersAreAscendingInASentence("hello world 5 x 5"));
            Console.WriteLine(CheckIfNumbersAreAscendingInASentence("sunset is at 7 51 pm overnight in the low 50 and 60 s"));
        }

        public static bool CheckIfNumbersAreAscendingInASentence(string s)
        {
            var allNums = new List<int>();
            var digit = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    string test = "";
                    int counter = -1;

                    for (int j = i; j < s.Length; j++)
                    {
                        if (char.IsDigit(s[j]))
                        {
                            test += s[j];
                            counter++;
                        }
                        else
                            break;
                    }
                    digit = int.Parse(test);

                    if (allNums.Count() > 0)
                    {
                        if (digit <= allNums.Last())
                            return false;
                    }

                    allNums.Add(digit);
                    i += counter;
                }
            }

            return true;
        }
    }
}
