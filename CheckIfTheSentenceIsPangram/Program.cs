using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfTheSentenceIsPangram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfTheSentenceIsPangram("thequickbrownfoxjumpsoverthelazydog"));
            Console.WriteLine(CheckIfTheSentenceIsPangram("leetcode"));
        }

        public static bool CheckIfTheSentenceIsPangram(string sentence)
        {
            var hashSet = new HashSet<char>();

            for (int i = 0; i < sentence.Length; i++)
                hashSet.Add(sentence[i]);

            if (hashSet.Count() == 26)
                return true;
            else
                return false;
        }
    }
}
