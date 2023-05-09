using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            while (command != "End")
            {
                var strs = command.Split(',').ToArray();
                Console.WriteLine(LongestCommonPrefix(strs));
                command = Console.ReadLine();
            }
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";
            else if (strs.Length == 1)
                return String.Join("", strs);

            string res = strs[0];
            int i = res.Length;

            foreach (string word in strs)
            {
                int j = 0;

                foreach (char c in word)
                {
                    if (j >= i || res[j] != c)
                        break;
                    j += 1;
                }
                i = Math.Min(i, j);
            }
            return res.Substring(0, i);
        }
    }
}
