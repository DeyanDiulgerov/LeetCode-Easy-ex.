using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Test
{
    public class Solution
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var t = Console.ReadLine();


            Console.WriteLine(IsAnagram(s, t));
        }

        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var wordS = s.ToCharArray();
            var wordT = t.ToCharArray();

            Array.Sort(wordS);
            Array.Sort(wordT);

            for (int i = 0; i < wordS.Length; i++)
            {
                if (wordS[i] != wordT[i])
                    return false;
            }

            return true;
        }
    }
}
