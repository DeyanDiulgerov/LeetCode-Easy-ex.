using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ClearDigits("abc"));
            Console.WriteLine(ClearDigits("cb34"));
        }
        public static string ClearDigits(string s)
        {
            var stack = new Stack<char>();
            foreach (char ch in s)
            {
                if (char.IsLetter(ch))
                    stack.Push(ch);
                else
                    stack.Pop();
            }
            return String.Join("", stack.Reverse());
        }
    }
}
