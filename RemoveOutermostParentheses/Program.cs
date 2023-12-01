using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveOutermostParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveOutermostParentheses("(()())(())"));
            Console.WriteLine(RemoveOutermostParentheses("(()())(())(()(()))"));
            Console.WriteLine(RemoveOutermostParentheses("()()"));
        }
        public static string RemoveOutermostParentheses(string s)
        {
            int leftCount = 0, rightCount = 0;
            string substring = "";
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    leftCount++;
                else
                    rightCount++;

                substring += s[i];

                if (leftCount == rightCount)
                {
                    substring = substring.Remove(0, 1);
                    substring = substring.Remove(substring.Length - 1, 1);
                    leftCount = 0;
                    rightCount = 0;
                    result += substring;
                    substring = "";
                }
            }
            return result;
        }
    }
}
