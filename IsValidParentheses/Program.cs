using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Given a string s containing just the characters '(', ')', '{', '}', '[' and ']',
            * determine if the input string is valid.
            An input string is valid if:
            Open brackets must be closed by the same type of brackets.
            Open brackets must be closed in the correct order.
            Every close bracket has a corresponding open bracket of the same type.*/


            Console.WriteLine(IsValidParentheses("{[]}"));
            Console.WriteLine(IsValidParentheses("()"));
            Console.WriteLine(IsValidParentheses("()[]{}"));
            Console.WriteLine(IsValidParentheses("(]"));
        }

        public static bool IsValidParentheses(string s)
        {
            if (s == null || s == string.Empty)
                return false;

            int n = -1;
            while (n != s.Length)
            {
                n = s.Length;
                s = s
                .Replace("()", "")
                .Replace("{}", "")
                .Replace("[]", "");
            }

            if (s.Length == 0)
                return true;
            else
                return false;
        }
    }
}
