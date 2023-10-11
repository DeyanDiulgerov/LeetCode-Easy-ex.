using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestNiceSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestNiceSubstring("qQUjJ"));
            Console.WriteLine(LongestNiceSubstring("cChH"));
            Console.WriteLine(LongestNiceSubstring("dDzeE"));
            Console.WriteLine(LongestNiceSubstring("YazaAay"));
            Console.WriteLine(LongestNiceSubstring("Bb"));
            Console.WriteLine(LongestNiceSubstring("c"));
        }
        public static string LongestNiceSubstring(string s)
        {
            var allSubstrings = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                bool isNice = false;
                var test = "";
                test += s[i];

                for (int j = i + 1; j < s.Length; j++)
                {
                    test += s[j];

                    for (int t = 0; t < test.Length; t++)
                    {
                        if (char.IsUpper(test[t]) && test.Contains(test[t].ToString().ToLower()))
                            isNice = true;
                        else if (char.IsLower(test[t]) && test.Contains(test[t].ToString().ToUpper()))
                            isNice = true;
                        else
                        {
                            isNice = false;
                            break;
                        }

                    }
                    if (isNice)
                        allSubstrings.Add(test);
                }
            }
            if (allSubstrings.Count() > 0)
            {
                allSubstrings = allSubstrings.OrderByDescending(x => x.Length).ToList();
                Console.WriteLine(String.Join(",", allSubstrings));
                return allSubstrings.First();
            }
            else
                return "";
        }
    }
}
