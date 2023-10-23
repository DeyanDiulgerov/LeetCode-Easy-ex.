using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackspaceStringCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BackspaceStringCompare("y#fo##f", "y#f#o##f"));
            Console.WriteLine(BackspaceStringCompare("a##c", "#a#c"));
            Console.WriteLine(BackspaceStringCompare("ab##", "c#d#"));
            Console.WriteLine(BackspaceStringCompare("ab#c", "ad#c"));
            Console.WriteLine(BackspaceStringCompare("a#c", "b"));
        }

        public static bool BackspaceStringCompare(string s, string t)
        {
            for (int i = 0; i < s.Length; i++)
                if (s[i] == '#' && i != 0)
                {
                    s = s.Remove(i - 1, 2);
                    if (i >= 2)
                        i -= 2;
                    else
                        i--;
                }

            for (int i = 0; i < t.Length; i++)
                if (t[i] == '#' && i != 0)
                {
                    t = t.Remove(i - 1, 2);
                    if (i >= 2)
                        i -= 2;
                    else
                        i--;
                }

            s = s.Trim('#');
            t = t.Trim('#');

            if (s == t)
                return true;
            else
                return false;
        }
    }
}
