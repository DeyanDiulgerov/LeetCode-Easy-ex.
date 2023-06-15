using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUniqueCharInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = "leetcode";
            var input2 = "loveleetcode";
            var input3 = "aabb";
            var input4 = "aadadaad";
            var input5 = "ab";
            var input6 = "aa";
            var input7 = "c";
            var input8 = "abac";
            var input9 = "abcc";
            var input10 = "aac";
            var input11 = "abcdefgh";
            var input12 = "aabbvvcc";

            Console.WriteLine(FirstUniqueChar(input1));
            Console.WriteLine(FirstUniqueChar(input2));
            Console.WriteLine(FirstUniqueChar(input3));
            Console.WriteLine(FirstUniqueChar(input4));
            Console.WriteLine(FirstUniqueChar(input5));
            Console.WriteLine(FirstUniqueChar(input6));
            Console.WriteLine(FirstUniqueChar(input7));
            Console.WriteLine(FirstUniqueChar(input8));
            Console.WriteLine(FirstUniqueChar(input9));
            Console.WriteLine(FirstUniqueChar(input10));
            Console.WriteLine(FirstUniqueChar(input11));
            Console.WriteLine(FirstUniqueChar(input12));
        }

        public static int FirstUniqueChar(string s)
        {
            if (s.Length == 1)
                return 0;
            else if (s.Length == 2 && s[0] != s[1])
                return 0;

            var newChamp = 0;
            bool isFound = true;

            for (int i = 0; i < s.Length; i++)
            {
                isFound = true;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] != s[j] && i != j)
                    {
                        newChamp = i;
                    }
                    else if (s[i] == s[j] && i != j)
                    {
                        newChamp = -1;
                        isFound = false;
                        break;
                    }
                }
                if (isFound)
                    break;
            }
            return newChamp;
        }
    }
}
