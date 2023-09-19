using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAllAdjacentDuplicatesInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveAllAdjacentDuplicatesInString("abbaca"));
            Console.WriteLine(RemoveAllAdjacentDuplicatesInString("azxxzy"));
        }

        public static string RemoveAllAdjacentDuplicatesInString(string s)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(s[0]);
            for (int i = 1; i < s.Length; i++)
            {
                if (sb.Length > 0 && s[i] == sb[sb.Length - 1])
                    sb.Remove(sb.Length - 1, 1);
                else
                    sb.Append(s[i]);
            }

            return sb.ToString();
        }
    }
}
