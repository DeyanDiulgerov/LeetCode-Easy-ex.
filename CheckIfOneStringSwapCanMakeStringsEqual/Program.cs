using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfOneStringSwapCanMakeStringsEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfOneStringSwapCanMakeStringsEqual("abcd", "dcba"));
            Console.WriteLine(CheckIfOneStringSwapCanMakeStringsEqual("bank", "kanb"));
            Console.WriteLine(CheckIfOneStringSwapCanMakeStringsEqual("attack", "defend"));
            Console.WriteLine(CheckIfOneStringSwapCanMakeStringsEqual("kelb", "kelb"));
        }

        public static bool CheckIfOneStringSwapCanMakeStringsEqual(string s1, string s2)
        {
            if (s1 == s2)
                return true;

            var permS1 = s1;

            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s1.Length; j++)
                {
                    if (i != j)
                    {
                        var first = s1[i];
                        var second = s1[j];

                        s1 = s1.Remove(i, 1);
                        s1 = s1.Insert(i, second.ToString());
                        s1 = s1.Remove(j, 1);
                        s1 = s1.Insert(j, first.ToString());

                        if (s1 == s2)
                            return true;
                    }

                    s1 = permS1;
                }
            }

            return false;
        }
    }
}
