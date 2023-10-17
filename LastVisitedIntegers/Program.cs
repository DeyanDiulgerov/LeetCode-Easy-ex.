using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastVisitedIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", LastVisitedIntegers(
                new List<string>() { "prev", "prev", "prev", "27" })));
            Console.WriteLine(String.Join(",", LastVisitedIntegers(
                new List<string>() { "1", "2", "prev", "prev", "prev" })));
            Console.WriteLine(String.Join(",", LastVisitedIntegers(
                new List<string>() { "1", "prev", "2", "prev", "prev" })));
        }

        public static IList<int> LastVisitedIntegers(IList<string> words)
        {
            var allNums = new List<int>();
            var resultList = new List<int>();
            var prevCounter = 0;

            for (int i = 0; i < words.Count(); i++)
            {
                if (words[i] == "prev")
                {
                    prevCounter++;
                    if (allNums.Count() < prevCounter)
                        resultList.Add(-1);
                    else
                    {
                        var num = allNums[allNums.Count() - prevCounter];
                        resultList.Add(num);
                    }
                }
                else
                {
                    allNums.Add(int.Parse(words[i]));
                    prevCounter = 0;
                }
            }

            return resultList;
        }
    }
}
