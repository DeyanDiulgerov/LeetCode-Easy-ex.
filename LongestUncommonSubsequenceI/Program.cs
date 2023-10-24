using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestUncommonSubsequenceI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestUncommonSubsequenceI("aba", "cdc"));
            Console.WriteLine(LongestUncommonSubsequenceI("aaa", "bbb"));
            Console.WriteLine(LongestUncommonSubsequenceI("aaa", "aaa"));
        }
        public static int LongestUncommonSubsequenceI(string a, string b)
        {
            var max = 0;
            var firstLUS = 0;
            var secondLUS = 0;
            var test = "";

            for (int i = 0; i < a.Length; i++)
            {
                test += a[i];

                if (a.Contains(test) && !b.Contains(test))
                    firstLUS = test.Length;
            }

            test = "";

            for (int i = 0; i < b.Length; i++)
            {
                test += b[i];

                if (b.Contains(test) && !a.Contains(test))
                    secondLUS = test.Length;
            }

            max = Math.Max(firstLUS, secondLUS);
            if (max == 0)
                return -1;
            else
                return max;
        }
    }
}
