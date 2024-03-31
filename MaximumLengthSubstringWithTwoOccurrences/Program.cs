using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumLengthSubstringWithTwoOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumLengthSubstringWithTwoOccurrences("bcbbbcba"));
            Console.WriteLine(MaximumLengthSubstringWithTwoOccurrences("aaaa"));
        }
        public static int MaximumLengthSubstringWithTwoOccurrences(string s)
        {
            var map = new Dictionary<char, int>();
            int max = 0;
            int left = 0;
            for (int right = 0; right < s.Length; right++)
            {
                if (!map.ContainsKey(s[right]))
                    map.Add(s[right], 1);
                else
                    map[s[right]]++;
                while (map[s[right]] > 2)
                {
                    max = Math.Max(max, right - left);
                    map[s[left]]--;
                    left++;
                }
            }
            max = Math.Max(max, s.Length - left);
            return max;
        }
    }
}
