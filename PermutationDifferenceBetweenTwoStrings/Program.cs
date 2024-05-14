using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationDifferenceBetweenTwoStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PermutationDifferenceBetweenTwoStrings("abc", "bac"));
            Console.WriteLine(PermutationDifferenceBetweenTwoStrings("abcde", "edbac"));
        }
        public static int PermutationDifferenceBetweenTwoStrings(string s, string t)
        {
            var mapS = new Dictionary<char, int>();
            var mapT = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                mapS.Add(s[i], i);
                mapT.Add(t[i], i);
            }
            int res = 0;
            foreach (var kvp in mapS)
                res += Math.Abs(kvp.Value - mapT[kvp.Key]);
            return res;
        }
    }
}
