using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumScoreAfterSplittingAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumScoreAfterSplittingAString("011101"));
            Console.WriteLine(MaximumScoreAfterSplittingAString("00111"));
            Console.WriteLine(MaximumScoreAfterSplittingAString("1111"));
        }

        public static int MaximumScoreAfterSplittingAString(string s)
        {
            var left = 0;
            var right = 1;
            var allMaxes = new List<int>();

            for (int j = 0; j < s.Length - 1; j++)
            {
                var newMax = 0;

                for (int i = 0; i <= left; i++)
                {
                    if (s[i] == '0')
                        newMax++;
                }
                for (int i = right; i < s.Length; i++)
                {
                    if (s[i] == '1')
                        newMax++;
                }

                left++;
                right++;
                allMaxes.Add(newMax);
            }

            allMaxes.Sort();
            return allMaxes.Last();
        }
    }
}
