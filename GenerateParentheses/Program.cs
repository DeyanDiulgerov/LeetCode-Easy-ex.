using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine(String.Join(",", LetterCombinations("23")));
             Console.WriteLine(String.Join(",", LetterCombinations("")));
             Console.WriteLine(String.Join(",", LetterCombinations("2")));*/

            /*Console.WriteLine(IsValidParentheses("()"));
            Console.WriteLine(IsValidParentheses("(){}[]"));
            Console.WriteLine(IsValidParentheses("(]"));
            Console.WriteLine(IsValidParentheses("({})"));*/

            Console.WriteLine(String.Join(",", GenerateParentheses(1)));
            Console.WriteLine(String.Join(",", GenerateParentheses(2)));
            Console.WriteLine(String.Join(",", GenerateParentheses(3)));
        }

        public static IList<string> GenerateParentheses(int n)
        {
            // n = 1 == ()
            // n = 2 == (), (()), ()()
            // n = 3 == "((()))","(()())","(())()","()(())","()()()"

            IList<string> lst = new List<string>();
            Gen(0, 0, "");
            return lst;

            void Gen(int i, int j, string cur)
            {
                if (i >= n && j >= n)
                {
                    lst.Add(cur);
                    return;
                }

                if (j < i)
                    Gen(i, j + 1, $"{cur})");

                if (i < n)
                    Gen(i + 1, j, $"{cur}(");
            }
        }
    }
}
