using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddyStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BuddyStrings("ab", "ba"));
            Console.WriteLine(BuddyStrings("ab", "ab"));
            Console.WriteLine(BuddyStrings("aa", "aa"));
        }

        public static bool BuddyStrings(string s, string goal)
        {
            if (s.Length != goal.Length || s.Length < 2 || goal.Length < 2)
                return false;

            if (s.Equals(goal))
            {
                var unique = new HashSet<char>(s);
                return unique.Count() < s.Length;
            }

            var diffIndices = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != goal[i])
                    diffIndices.Add(i);
                if (diffIndices.Count() > 2)
                    return false;
            }

            if (diffIndices.Count() != 2)
                return false;

            return s[diffIndices[0]] == goal[diffIndices[1]]
                && s[diffIndices[1]] == goal[diffIndices[0]];
        }
    }
}
