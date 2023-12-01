using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccurrencesAfterBigram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", OccurrencesAfterBigram
                ("alice is a good girl she is a good student", "a", "good")));
            Console.WriteLine(String.Join(",", OccurrencesAfterBigram
                ("we will we will rock you", "we", "will")));
        }

        public static string[] OccurrencesAfterBigram(string text, string first, string second)
        {
            var resultList = new List<string>();
            var splitted = text.Split(' ');

            for (int i = 0; i < splitted.Length - 2; i++)
            {
                if (splitted[i] == first && splitted[i + 1] == second)
                    resultList.Add(splitted[i + 2]);
            }
            return resultList.ToArray();
        }
    }
}
