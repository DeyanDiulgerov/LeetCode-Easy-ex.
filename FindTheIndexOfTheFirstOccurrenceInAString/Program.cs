using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheIndexOfTheFirstOccurrenceInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheIndexOfTheFirstOccurrenceInAString("sadbutsad", "sad"));
            Console.WriteLine(FindTheIndexOfTheFirstOccurrenceInAString("leetcode", "leeto"));
        }
        // Sliding Window - The acceptable solution
        public static int FindTheIndexOfTheFirstOccurrenceInAString(string haystack, string needle)
        {
            string substring = String.Concat(haystack.Take(needle.Length));
            int left = 0, right = substring.Length - 1;

            if (substring == needle)
                return 0;

            while (right < haystack.Length - 1)
            {
                substring = substring.Remove(0, 1);
                left++;
                right++;
                substring += haystack[right];

                if (substring == needle)
                    return left;
            }

            return -1;
        }
        //Index Of - people say its not an acceptable solution
        public int StrStr(string haystack, string needle) 
        {
            return haystack.IndexOf(needle);
        }
    }
}
