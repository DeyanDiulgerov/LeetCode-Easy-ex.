using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumMovesToConvertString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumMovesToConvertString("OXOX"));
            Console.WriteLine(MinimumMovesToConvertString("XXX"));
            Console.WriteLine(MinimumMovesToConvertString("XXOX"));
            Console.WriteLine(MinimumMovesToConvertString("OOOO"));
        }
        public static int MinimumMovesToConvertString(string s)
        {
            if (s.All(x => x == 'O'))
                return 0;

            int counter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'O')
                    continue;

                counter++;
                i += 2;
            }
            return counter;
        }
    }
}
