using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfStringIsAPrefixOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfStringIsAPrefixOfArray("iloveleetcode", new string[] { "i", "love", "leetcode", "apples" }));
            Console.WriteLine(CheckIfStringIsAPrefixOfArray("iloveleetcode", new string[] { "apples", "i", "love", "leetcode" }));

        }

        public static bool CheckIfStringIsAPrefixOfArray(string s, string[] words)
        {
            var result = "";

            for (int i = 0; i < words.Length; i++)
            {
                result += words[i];

                if (result == s)
                    return true;
            }
            return false;
        }
    }
}
