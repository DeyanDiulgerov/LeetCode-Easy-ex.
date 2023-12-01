using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedistributeCharactersToMakeAllStringsEqual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RedistributeCharactersToMakeAllStringsEqual(new string[] { "abc", "aabc", "bc" }));
            Console.WriteLine(RedistributeCharactersToMakeAllStringsEqual(new string[] { "ab", "a" }));
        }
        public static bool RedistributeCharactersToMakeAllStringsEqual(string[] words)
        {
            int n = words.Length;
            var combined = String.Join("", words);
            combined = String.Concat(combined.OrderBy(x => x));
            var hashed = new HashSet<char>(combined);
            var listed = new List<char>(hashed);

            for (int i = 0; i < listed.Count(); i++)
            {
                if (combined.Count(x => x == listed[i]) % n != 0)
                    return false;
            }

            return true;
        }
    }
}
