using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RearrangeCharactersToMakeTargetString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RearrangeCharactersToMakeTargetString
                ("lrnvlcqukanpdnluowenfxquitzryponxsikhciohyostvmk" +
                "apkfpglzikitwiraqgchxnpryhwpuwpozacjhmwhjvslprqlnxrk", "woijih"));
            Console.WriteLine(RearrangeCharactersToMakeTargetString("ilovecodingonleetcode", "code"));
            Console.WriteLine(RearrangeCharactersToMakeTargetString("abcba", "abc"));
            Console.WriteLine(RearrangeCharactersToMakeTargetString("abbaccaddaeea", "aaaaa"));
        }

        public static int RearrangeCharactersToMakeTargetString(string s, string target)
        {
            int counter = 0;
            string permTarget = target;
            var skippedCharsList = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (target.Contains(s[i]))
                {
                    var index = target.IndexOf(s[i]);
                    target = target.Remove(index, 1);
                }
                else if (permTarget.Contains(s[i]))
                    skippedCharsList.Add(s[i]);

                if (target.Length == 0)
                {
                    counter++;
                    target = permTarget;
                }
            }

            for (int i = 0; i < skippedCharsList.Count(); i++)
            {
                if (target.Contains(skippedCharsList[i]))
                {
                    var index = target.IndexOf(skippedCharsList[i]);
                    target = target.Remove(index, 1);
                }
                if (target.Length == 0)
                {
                    counter++;
                    target = permTarget;
                }
            }

            return counter;
        }
    }
}
