using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestUnequalAdjacentGroupsSubsequenceI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", LongestUnequalAdjacentGroupsSubsequenceI(
                new string[] { "e", "a", "b" }, new int[] { 0, 0, 1 })));
            Console.WriteLine(String.Join(",", LongestUnequalAdjacentGroupsSubsequenceI(
               new string[] { "a", "b", "c", "d" }, new int[] { 1, 0, 1, 1 })));
        }
        public static IList<string> LongestUnequalAdjacentGroupsSubsequenceI(string[] words, int[] groups)
        {
            int n = words.Length; // == groups.Length
            List<string> result = new List<string>();
            int left = 0, right = 1;
            while (right <= n)
            {
                while (right < n && groups[left] == groups[right])
                    right++;
                result.Add(words[left]);
                left = right;
                right = left + 1;
            }
            return result;
        }
    }
}
