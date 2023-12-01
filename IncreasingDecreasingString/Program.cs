using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingDecreasingString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IncreasingDecreasingString("leetcode"));
            Console.WriteLine(IncreasingDecreasingString("aaaabbbbcccc"));
            Console.WriteLine(IncreasingDecreasingString("rat"));
        }
        public static string IncreasingDecreasingString(string s)
        {
            int n = s.Length;
            var result = "";

            while (result.Length < n)
            {
                var hashed = new HashSet<char>(s);
                var listed = new List<char>(hashed);
                listed.Sort();

                for (int i = 0; i < listed.Count(); i++)
                {
                    result += listed[i];
                    var index = s.IndexOf(listed[i]);
                    s = s.Remove(index, 1);
                }
                if (result.Length >= n)
                    break;
                hashed = new HashSet<char>(s);
                listed = new List<char>(hashed);
                listed.Sort();

                for (int i = listed.Count() - 1; i >= 0; i--)
                {
                    result += listed[i];
                    var index = s.IndexOf(listed[i]);
                    s = s.Remove(index, 1);
                }
            }
            return result;
        }
    }
}
