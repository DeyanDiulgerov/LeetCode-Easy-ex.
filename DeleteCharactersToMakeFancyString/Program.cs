using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteCharactersToMakeFancyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DeleteCharactersToMakeFancyString("aaabaaaa"));
            Console.WriteLine(DeleteCharactersToMakeFancyString("leeetcode"));
            Console.WriteLine(DeleteCharactersToMakeFancyString("aab"));
        }

        public static string DeleteCharactersToMakeFancyString(string s)
        {
            var sb = new StringBuilder();
            sb.Append(s[0]);
            int counter = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (sb[sb.Length - 1] == s[i])
                    counter++;
                else
                    counter = 1;

                if (counter < 3)
                    sb.Append(s[i]);
            }

            return sb.ToString();
        }
    }
}
