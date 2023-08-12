using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWordsThatCanBeFormedByCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindWordsThatCanBeFormedByCharacters(new string[] { "cat", "bt", "hat", "tree" }, "atach"));
            Console.WriteLine(FindWordsThatCanBeFormedByCharacters(new string[] { "hello", "world", "leetcode" }, "welldonehoneyr"));
        }

        public static int FindWordsThatCanBeFormedByCharacters(string[] words, string chars)
        {
            int sum = 0;
            var permanentChars = chars;

            foreach (var word in words)
            {
                string result = "";
                chars = permanentChars;

                foreach (var letter in word)
                {
                    if (chars.Contains(letter))
                    {
                        result += letter;
                        var index = chars.IndexOf(letter);
                        chars = chars.Remove(index, 1);
                    }
                    else
                    {
                        result = "";
                        break;
                    }
                }
                if (words.Any(x => x == result))
                    sum += result.Length;
            }

            return sum;
        }
    }
}
