using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToLowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerCase("Hello"));
            Console.WriteLine(ToLowerCase("here"));
            Console.WriteLine(ToLowerCase("LOVELY"));
        }

        public static string ToLowerCase(string s)
            => s = s.ToLower();
    }
}
