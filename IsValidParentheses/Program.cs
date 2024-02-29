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
            Console.WriteLine(IsValid("]"));
            Console.WriteLine(IsValid("["));
            Console.WriteLine(IsValid("(([]))"));
            Console.WriteLine(IsValid("(([)])"));
            Console.WriteLine(IsValidParentheses("{[]}"));
            Console.WriteLine(IsValidParentheses("()"));
            Console.WriteLine(IsValidParentheses("()[]{}"));
            Console.WriteLine(IsValidParentheses("(]"));
        }
        //Intuative way
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
        //Stack and switch cases
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                        stack.Push('(');
                        break;
                    case '{':
                        stack.Push('{');
                        break;
                    case '[':
                        stack.Push('[');
                        break;
                    case ')':
                        if (stack.Count() == 0 || stack.Peek() != '(')
                            return false;
                        else
                            stack.Pop();
                        break;
                    case '}':
                        if (stack.Count() == 0 || stack.Peek() != '{')
                            return false;
                        else
                            stack.Pop();
                        break;
                    case ']':
                        if (stack.Count() == 0 || stack.Peek() != '[')
                            return false;
                        else
                            stack.Pop();
                        break;
                }
            }
            return stack.Count() == 0;
        }
    }
}
