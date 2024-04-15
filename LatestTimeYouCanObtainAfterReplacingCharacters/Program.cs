using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatestTimeYouCanObtainAfterReplacingCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LatestTimeYouCanObtainAfterReplacingCharacters("1?:?4"));
            Console.WriteLine(LatestTimeYouCanObtainAfterReplacingCharacters("0?:5?"));
            Console.WriteLine(LatestTimeYouCanObtainAfterReplacingCharacters("??:?4"));
            Console.WriteLine(LatestTimeYouCanObtainAfterReplacingCharacters("?3:12"));
        }
        public static string LatestTimeYouCanObtainAfterReplacingCharacters(string s)
        {
            if (s[4] == '?')
            {
                s = s.Remove(4, 1);
                s = s.Insert(4, "9");
            }
            if (s[3] == '?')
            {
                s = s.Remove(3, 1);
                s = s.Insert(3, "5");
            }
            if (s[0] == '?')
            {
                if (s[1] == '?' || s[1] == '0' || s[1] == '1')
                {
                    s = s.Remove(0, 1);
                    s = s.Insert(0, "1");
                }
                else
                {
                    s = s.Remove(0, 1);
                    s = s.Insert(0, "0");
                }
            }
            if (s[1] == '?')
            {
                if (s[0] == '1')
                {
                    s = s.Remove(1, 1);
                    s = s.Insert(1, "1");
                }
                else if (s[0] == '0')
                {
                    s = s.Remove(1, 1);
                    s = s.Insert(1, "9");
                }
            }
            return s;
        }
    }
}
