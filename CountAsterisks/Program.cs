using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountAsterisks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountAsterisks("l|*e*et|c**o|*de|"));
            Console.WriteLine(CountAsterisks("iamprogrammer"));
            Console.WriteLine(CountAsterisks("yo|uar|e**|b|e***au|tifu|l"));
        }

        public static int CountAsterisks(string s)
        {
            int counter = 0;
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (counter == 2)
                    counter = 0;
                if (s[i] == '|')
                    counter++;
                if (s[i] == '*' && counter == 0)
                    result++;
            }
            return result;
        }

    }
}
