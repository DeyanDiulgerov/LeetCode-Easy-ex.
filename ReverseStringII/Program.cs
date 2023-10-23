using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseStringII("abcdefg", 3));
            Console.WriteLine(ReverseStringII("abcdefg", 8));
            Console.WriteLine(ReverseStringII("abcdefg", 2));
            Console.WriteLine(ReverseStringII("abcd", 2));
        }

        public static string ReverseStringII(string s, int k)
        {
            for (int i = 0; i < s.Length; i += k * 2)
            {
                var reversed = "";
                var test = "";

                if (i + k < s.Length)
                    for (int j = i; j < i + k; j++)
                        test += s[j];
                else
                    for (int j = i; j < s.Length; j++)
                        test += s[j];

                for (int r = test.Length - 1; r >= 0; r--)
                    reversed += test[r];

                if (k < s.Length && i + k < s.Length)
                    s = s.Remove(i, k);
                else if (k < s.Length && i + k >= s.Length)
                    s = s.Remove(i, s.Length - i);
                else
                    s = s.Remove(i, s.Length);


                s = s.Insert(i, reversed);
            }
            return s;
        }
    }
}
