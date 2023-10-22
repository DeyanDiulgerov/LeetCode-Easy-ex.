using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RotateString("abcde", "cdeab"));
            Console.WriteLine(RotateString("abcde", "abced"));
        }

        public static bool RotateString(string s, string goal)
        {
            var usedStrings = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                if (usedStrings.Contains(s))
                    return false;
                if (s == goal)
                    return true;
                else
                    usedStrings.Add(s);

                var curr = s[0];
                s = s.Remove(0, 1);
                s += curr;
            }
            if (s == goal)
                return true;
            else
                return false;
        }
    }
}
