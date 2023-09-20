using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumStringthLengthAfterRemovingSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumStringthLengthAfterRemovingSubstrings("CCCCDDDD"));
            Console.WriteLine(MinimumStringthLengthAfterRemovingSubstrings("ABFCACDB"));
            Console.WriteLine(MinimumStringthLengthAfterRemovingSubstrings("ACBBD"));
        }

        public static int MinimumStringthLengthAfterRemovingSubstrings(string s)
        {
            int n = s.Length;

            for (int i = 0; i < n; i++)
            {
                if (s.Contains("AB"))
                {
                    var index = s.IndexOf("AB");
                    s = s.Remove(index, 2);
                }
                if (s.Contains("CD"))
                {
                    var index = s.IndexOf("CD");
                    s = s.Remove(index, 2);
                }
            }

            return s.Length;
        }
    }
}
