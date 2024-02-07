using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfChangingKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfChangingKeys("aAbBacC"));
            Console.WriteLine(NumberOfChangingKeys("aAbBcC"));
            Console.WriteLine(NumberOfChangingKeys("AaAaAaaA"));
        }
        public static int NumberOfChangingKeys(string s)
        {
            int left = 0, right = 0, count = 0;
            while (right < s.Length)
            {
                right = left + 1;
                while (right < s.Length && s[left].ToString().ToLower() == s[right].ToString().ToLower())
                    right++;
                if (right >= s.Length)
                    break;
                count++;
                left = right;
            }
            return count;
        }
    }
}
