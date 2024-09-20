using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringThatSatisfyKConstraintI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSubstringThatSatisfyKConstraintI("10101", 1));
            Console.WriteLine(CountSubstringThatSatisfyKConstraintI("1010101", 2));
            Console.WriteLine(CountSubstringThatSatisfyKConstraintI("11111", 1));
        }
        public static int CountSubstringThatSatisfyKConstraintI(string s, int k)
        {
            int l = 0, r = 0, z = 0, o = 0;
            int res = 0;
            while (r < s.Length)
            {
                if (s[r] == '1')
                    o++;
                else
                    z++;

                while (z > k && o > k)
                {
                    if (s[l] == '1')
                        o--;
                    else
                        z--;
                    l++;
                }
                res += r + 1 - l;
                r++;
            }
            return res;
        }
    }
}
