using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreOfAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ScoreOfAString("hello"));
            Console.WriteLine(ScoreOfAString("zaz"));
        }
        public static int ScoreOfAString(string s)
        {
            int finalScore = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                int newScore = Math.Abs(s[i] - s[i + 1]);
                finalScore += newScore;
            }
            return finalScore;
        }
    }
}
