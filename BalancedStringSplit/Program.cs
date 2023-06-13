using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedStringSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BalancedStringSplit("RLRRLLRLRL"));
            Console.WriteLine(BalancedStringSplit("RLRRRLLRLL"));
            Console.WriteLine(BalancedStringSplit("LLLLRRRR"));
        }

        public static int BalancedStringSplit(string s)
        {
            int r = 0, l = 0, count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'R')
                    r++;
                else
                    l++;

                if (r == l)
                {
                    count++;
                    r = 0;
                    l = 0;
                }
            }
            return count;
        }
    }
}
