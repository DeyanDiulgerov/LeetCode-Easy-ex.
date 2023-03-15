
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomaToInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (s == null || s == string.Empty)
                Console.WriteLine(0);

            Dictionary<string, int> dict = new Dictionary<string, int>();
            int result = 0;

            dict.Add("I", 1);
            dict.Add("V", 5);
            dict.Add("X", 10);
            dict.Add("L", 50);
            dict.Add("C", 100);
            dict.Add("D", 500);
            dict.Add("M", 1000);
            dict.Add("IV", 4);
            dict.Add("IX", 9);
            dict.Add("XL", 40);
            dict.Add("XC", 90);
            dict.Add("CD", 400);
            dict.Add("CM", 900);

            for (int i = 0; i < s.Length; i++)
                if ((s[i] == 'I' || s[i] == 'X' || s[i] == 'C') && i < s.Length - 1 && dict.ContainsKey(s.Substring(i, 2)))
                    result += dict[s.Substring(i++, 2)];
                else
                    result += dict[s[i].ToString()];

            Console.WriteLine(result);
        }
    }
}
