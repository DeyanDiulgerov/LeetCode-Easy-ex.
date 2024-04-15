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
            char[] charS = s.ToCharArray();
            if (charS[4] == '?')
                charS[4] = '9';
            if (charS[3] == '?')
                charS[3] = '5';
            if (charS[0] == '?')
            {
                if (charS[1] == '?' || charS[1] == '0' || charS[1] == '1')
                    charS[0] = '1';
                else
                    charS[0] = '0';
            }
            if (charS[1] == '?')
            {
                if (charS[0] == '1')
                    charS[1] = '1';
                else if (charS[0] == '0')
                    charS[1] = '9';
            }
            return String.Join("", charS);
        }
    }
}
