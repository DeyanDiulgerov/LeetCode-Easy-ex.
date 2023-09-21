using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerContiguousSegmentsOfOnesAndZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongerContiguousSegmentsOfOnesAndZeroes("011000111"));
            Console.WriteLine(LongerContiguousSegmentsOfOnesAndZeroes("1101"));
            Console.WriteLine(LongerContiguousSegmentsOfOnesAndZeroes("111000"));
            Console.WriteLine(LongerContiguousSegmentsOfOnesAndZeroes("110100010"));
        }

        public static bool LongerContiguousSegmentsOfOnesAndZeroes(string s)
        {
            int onesMax = 0;
            int zeroesMax = 0;
            var newOnes = 0;
            var newZeroes = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                    newOnes++;
                else
                {
                    onesMax = Math.Max(onesMax, newOnes);
                    newOnes = 0;
                }

            }
            onesMax = Math.Max(onesMax, newOnes);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0')
                    newZeroes++;
                else
                {
                    zeroesMax = Math.Max(zeroesMax, newZeroes);
                    newZeroes = 0;
                }

            }
            zeroesMax = Math.Max(zeroesMax, newZeroes);

            if (onesMax > zeroesMax)
                return true;
            else
                return false;
        }
    }
}
