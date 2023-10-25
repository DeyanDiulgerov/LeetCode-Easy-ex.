using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfSegmentsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfSegmentsInAString("Of all the gin joints in all the towns in all the world,   "));
            Console.WriteLine(NumberOfSegmentsInAString("                "));
            Console.WriteLine(NumberOfSegmentsInAString("Hello, my name is John"));
            Console.WriteLine(NumberOfSegmentsInAString("Hello"));
        }
        public static int NumberOfSegmentsInAString(string s)
        {
            if (s.All(x => x == ' ') || s == "")
                return 0;

            var splitted = s.Split(' ');
            var listed = new List<string>(splitted);
            listed.RemoveAll(x => x == "");

            return listed.Count();
        }
    }
}
