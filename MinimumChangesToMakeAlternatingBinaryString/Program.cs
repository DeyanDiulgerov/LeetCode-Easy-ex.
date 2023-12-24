using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumChangesToMakeAlternatingBinaryString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumChangesToMakeAlternatingBinaryString("0100"));
            Console.WriteLine(MinimumChangesToMakeAlternatingBinaryString("10"));
            Console.WriteLine(MinimumChangesToMakeAlternatingBinaryString("1111"));
        }
        public static int MinimumChangesToMakeAlternatingBinaryString(string s)
        {
            int counter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (s[i] == '0')
                        counter++;
                }
                else
                {
                    if (s[i] == '1')
                        counter++;
                }
            }
            return Math.Min(counter, s.Length - counter);
        }
    }
}
