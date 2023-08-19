using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestSubstringBetweenTwoEqualCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestSubstringBetweenTwoEqualCharacters("pfwftcwdbiodyoojbebtwoyqemmsgmsryugkkcwykhtaczj"));
            Console.WriteLine(LargestSubstringBetweenTwoEqualCharacters("scayofdzca"));
            Console.WriteLine(LargestSubstringBetweenTwoEqualCharacters("aa"));
            Console.WriteLine(LargestSubstringBetweenTwoEqualCharacters("abca"));
            Console.WriteLine(LargestSubstringBetweenTwoEqualCharacters("cbzxy"));
        }

        public static int LargestSubstringBetweenTwoEqualCharacters(string s)
        {
            var substringAndCount = new Dictionary<string, int>();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        var substring = s.Substring(i + 1, j - i - 1);
                        if (!substringAndCount.ContainsKey(substring))
                            substringAndCount.Add(substring, substring.Length);
                        else
                            substringAndCount[substring] = substring.Length;
                    }
                }
            }

            if (substringAndCount.Count() == 0)
                return -1;
            else
                return substringAndCount.OrderByDescending(x => x.Value).First().Value;
        }
    }
}
