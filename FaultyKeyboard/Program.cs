using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaultyKeyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FaultyKeyboard("string"));
            Console.WriteLine(FaultyKeyboard("poiinter"));
        }

        public static string FaultyKeyboard(string s)
        {
            var result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'i')
                {
                    var reversed = "";

                    for (int j = result.Length - 1; j >= 0; j--)
                        reversed += result[j];

                    result = reversed;
                }
                else
                    result += s[i];
            }

            return result;
        }
    }
}
