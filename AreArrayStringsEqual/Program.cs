using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreArrayStringsEqual
{
     class Program
     {
        static void Main(string[] args)
        {
            Console.WriteLine(AreArrayStringsEqual(new string[] { "abc", "d", "defg" }, new string[] { "abcddef" }));
            Console.WriteLine(AreArrayStringsEqual(new string[] { "ab", "c" }, new string[] { "a", "bc" }));
            Console.WriteLine(AreArrayStringsEqual(new string[] { "a", "cb" }, new string[] { "ab", "c" }));
            Console.WriteLine(AreArrayStringsEqual(new string[] { "abc", "d", "defg" }, new string[] { "abcddefg" }));
        }


        public static bool AreArrayStringsEqual(string[] word1, string[] word2)
        {
            if (word1 == null && word2 != null)
                return false;
            else if (word1 != null && word2 == null)
                return false;
            else if (word1 == null && word2 == null)
                return true;
            else
            {
                string result1 = "";
                string result2 = "";

                for (int i = 0; i < word1.Length; i++)
                    result1 += word1[i];

                for (int i = 0; i < word2.Length; i++)
                    result2 += word2[i];

                if (result1.Length != result2.Length)
                    return false;

                var shortest = Math.Min(result1.Length, result2.Length);

                for (int i = 0; i < shortest; i++)
                {
                    if (result1[i] != result2[i])
                        return false;
                }

                return true;
            }
        }
    }
}
