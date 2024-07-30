using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexicographicallySmallestStringAfterASwap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LexicographicallySmallestStringAfterASwap("45320"));
            Console.WriteLine(LexicographicallySmallestStringAfterASwap("001"));
        }
        public static string LexicographicallySmallestStringAfterASwap(string s)
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                int numI = s[i] - 48;
                int numJ = s[i + 1] - 48;
                if (IsSameParity(numI, numJ) && numI > numJ)
                {
                    char first = s[i];
                    char second = s[i + 1];
                    s = s.Remove(i, 1);
                    s = s.Insert(i, second.ToString());
                    s = s.Remove(i + 1, 1);
                    s = s.Insert(i + 1, first.ToString());
                    break;
                }
            }
            bool IsSameParity(int i, int j)
            {
                bool isSame = false;
                if (i % 2 == 0 && j % 2 == 0)
                    isSame = true;
                else if (i % 2 != 0 && j % 2 != 0)
                    isSame = true;
                return isSame;
            }
            return s;
        }
    }
}
