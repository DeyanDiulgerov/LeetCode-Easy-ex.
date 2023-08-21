using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimizedStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimizedStringLength("aaabc"));
            Console.WriteLine(MinimizedStringLength("cbbd"));
            Console.WriteLine(MinimizedStringLength("dddaaa"));
        }

        public static int MinimizedStringLength(string s)
            => s.Distinct().Count();
    }
}
