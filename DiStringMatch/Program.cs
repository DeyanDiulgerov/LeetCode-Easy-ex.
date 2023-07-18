using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiStringMatch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(String.Join(",", DiStringMatch("IDID")));
            Console.WriteLine(String.Join(",", DiStringMatch("III")));
            Console.WriteLine(String.Join(",", DiStringMatch("DDI")));
        }

        public static int[] DiStringMatch(string s)
        {
            int[] result = new int[s.Length + 1];
            int iCounter = 0;
            int dCounter = s.Length;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'I')
                {
                    result[i] = iCounter;
                    iCounter++;
                }
                else if (s[i] == 'D')
                {
                    result[i] = dCounter;
                    dCounter--;
                }
            }

            if (s[s.Length - 1] == 'I')
                result[s.Length] = iCounter;
            else if (s[s.Length - 1] == 'D')
                result[s.Length] = dCounter;

            return result;
        }
    }
}
