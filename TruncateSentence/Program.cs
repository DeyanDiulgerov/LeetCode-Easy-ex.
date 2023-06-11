using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruncateSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TruncateSentence("Hello how are you Contestant", 4));
            Console.WriteLine(TruncateSentence("What is the solution to this problem", 4));
            Console.WriteLine(TruncateSentence("chopper is not a tanuki", 5));
        }


        public static string TruncateSentence(string s, int k)
        {
            var result = "";
            var resultList = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                if (resultList.Count == k)
                    break;

                if (s[i] == ' ')
                {
                    resultList.Add(result);
                    result = "";
                }
                else if (i == s.Length - 1)
                {
                    result += s[i];
                    resultList.Add(result);
                    result = "";
                }
                else
                    result += s[i];
            }

            return String.Join(" ", resultList);
        }
    }
}
