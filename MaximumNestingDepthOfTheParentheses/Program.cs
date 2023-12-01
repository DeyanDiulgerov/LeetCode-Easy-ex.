using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNestingDepthOfTheParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumNestingDepthOfTheParentheses("(1())"));
            Console.WriteLine(MaximumNestingDepthOfTheParentheses("1"));
            Console.WriteLine(MaximumNestingDepthOfTheParentheses("()"));
            Console.WriteLine(MaximumNestingDepthOfTheParentheses("((8+7)*(3+9)-0)*(1*6)"));
            Console.WriteLine(MaximumNestingDepthOfTheParentheses("+(+(+)+)+"));
            Console.WriteLine(MaximumNestingDepthOfTheParentheses("(1+(2*3)+((8)/4))+1"));
            Console.WriteLine(MaximumNestingDepthOfTheParentheses("(1)+((2))+(((3)))"));
        }
        public static int MaximumNestingDepthOfTheParentheses(string s)
        {
            if (!s.Any(x => x == '(') && !s.Any(x => x == ')'))
                return 0;
            int max = 1;
            for (int i = 0; i < s.Length; i++)
            {
                int leftCount = 0, rightCount = 0;
                for (int l = i; l >= 0; l--)
                {
                    if (s[l] == '(')
                        leftCount++;
                    else if (s[l] == ')')
                        leftCount--;
                }
                for (int r = i + 1; r < s.Length; r++)
                {
                    if (s[r] == ')')
                        rightCount++;
                    else if (s[r] == '(')
                        rightCount--;
                }

                var depth = Math.Min(leftCount, rightCount);
                max = Math.Max(max, depth);
            }
            return max;
        }
    }
}
