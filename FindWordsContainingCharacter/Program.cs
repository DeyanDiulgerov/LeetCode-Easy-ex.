using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWordsContainingCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",",
                FindWordsContainingCharacter(new string[] { "leet", "code" }, 'e')));
            Console.WriteLine(String.Join(",",
                FindWordsContainingCharacter(new string[] { "abc", "bcd", "aaaa", "cbc" }, 'a')));
            Console.WriteLine(String.Join(",",
                FindWordsContainingCharacter(new string[] { "abc", "bcd", "aaaa", "cbc" }, 'z')));
        }
        public static IList<int> FindWordsContainingCharacter(string[] words, char x)
        {
            var resultList = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(x))
                    resultList.Add(i);
            }
            return resultList;
        }
    }
}
