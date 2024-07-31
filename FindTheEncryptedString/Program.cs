using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheEncryptedString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheEncryptedString("dart", 3));
            Console.WriteLine(FindTheEncryptedString("aaa", 1));
            Console.WriteLine(FindTheEncryptedString("dartef", 2));
            Console.WriteLine(FindTheEncryptedString("dartefgi", 5));
        }
        public static string FindTheEncryptedString(string s, int k)
        {
            int n = s.Length;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
                sb.Append(s[(i + k) % n]);
            return sb.ToString();
        }
    }
}
