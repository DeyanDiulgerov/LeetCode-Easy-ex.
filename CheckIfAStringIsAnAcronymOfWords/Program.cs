using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfAStringIsAnAcronymOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfAStringIsAnAcronymOfWords(new List<string>() { "alice", "bob", "charlie" }, "abc"));
            Console.WriteLine(CheckIfAStringIsAnAcronymOfWords(new List<string>() { "an", "apple" }, "a"));
            Console.WriteLine(CheckIfAStringIsAnAcronymOfWords(new List<string>() { "never", "gonna", "give", "up", "on", "you" }, "ngguoy"));
        }

        public static bool CheckIfAStringIsAnAcronymOfWords(IList<string> words, string s)
        {
            var testAcro = "";
            foreach (var item in words)
                testAcro += item[0];

            if (testAcro == s)
                return true;
            else
                return false;
        }
    }
}
