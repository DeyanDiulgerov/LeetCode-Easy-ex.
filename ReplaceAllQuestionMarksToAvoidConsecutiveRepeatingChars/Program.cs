using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceAllQuestionMarksToAvoidConsecutiveRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReplaceAllQuestionMarksToAvoidConsecutiveRepeatingChars("?"));
            Console.WriteLine(ReplaceAllQuestionMarksToAvoidConsecutiveRepeatingChars("?zs"));
            Console.WriteLine(ReplaceAllQuestionMarksToAvoidConsecutiveRepeatingChars("ubv?w"));
        }
        public static string ReplaceAllQuestionMarksToAvoidConsecutiveRepeatingChars(string s)
        {
            if (s.Length == 1 && s[0] == '?')
                return "a";

            var allChars = new List<char>();

            for (char i = 'a'; i <= 'z'; i++)
                allChars.Add(i);

            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0 && s[i] == '?')
                {
                    var newChar = allChars.FirstOrDefault(x => x != s[i + 1]).ToString();
                    s = s.Remove(i, 1);
                    s = s.Insert(i, newChar);
                }
                else if (i == s.Length - 1 && s[i] == '?')
                {
                    var newChar = allChars.FirstOrDefault(x => x != s[i - 1]).ToString();
                    s = s.Remove(i, 1);
                    s = s.Insert(i, newChar);
                }
                else if (s[i] == '?')
                {
                    var newChar = allChars.FirstOrDefault(x => x != s[i - 1] && x != s[i + 1]).ToString();
                    s = s.Remove(i, 1);
                    s = s.Insert(i, newChar);
                }
            }

            return s;
        }
    }
}
