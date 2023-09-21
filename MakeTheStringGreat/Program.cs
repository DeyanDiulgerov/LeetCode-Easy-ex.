using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeTheStringGreat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakeTheStringGreat("kkdsFuqUfSDKK"));
            Console.WriteLine(MakeTheStringGreat("jeSsEJ"));
            Console.WriteLine(MakeTheStringGreat("Pp"));
            Console.WriteLine(MakeTheStringGreat("leEeetcode"));
            Console.WriteLine(MakeTheStringGreat("abBAcC"));
            Console.WriteLine(MakeTheStringGreat("s"));
        }

        public static string MakeTheStringGreat(string s)
        {
            int n = s.Length;

            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (s[i].ToString().ToUpper() == s[i + 1].ToString()
                     && s[i].ToString() == s[i + 1].ToString().ToLower())
                    {
                        s = s.Remove(i + 1, 1);
                        s = s.Remove(i, 1);
                    }
                    else if (s[i].ToString() == s[i + 1].ToString().ToUpper()
                         && s[i].ToString().ToLower() == s[i + 1].ToString())
                    {
                        s = s.Remove(i + 1, 1);
                        s = s.Remove(i, 1);
                    }
                }
            }

            return s;
        }
    }
}
