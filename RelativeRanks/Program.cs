using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativeRanks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", RelativeRanks(new int[] { 5, 4, 3, 2, 1 })));
            Console.WriteLine(String.Join(",", RelativeRanks(new int[] { 10, 3, 8, 9, 4 })));
        }

        public static string[] RelativeRanks(int[] score)
        {
            int[] scoreSorted = new int[score.Length];
            string[] resultArr = new string[score.Length];
            score.CopyTo(scoreSorted, 0);

            Array.Sort(scoreSorted);
            Array.Reverse(scoreSorted);

            Dictionary<int, string> scoreMap = new Dictionary<int, string>();

            for (int i = 0; i < scoreSorted.Length; i++)
            {
                string val = "";
                if (i == 0)
                    val = "Gold Medal";
                else if (i == 1)
                    val = "Silver Medal";
                else if (i == 2)
                    val = "Bronze Medal";
                else
                    val = (i + 1).ToString();

                scoreMap.Add(scoreSorted[i], val);
            }

            for (int i = 0; i < score.Length; i++)
                resultArr[i] = scoreMap[score[i]];

            return resultArr;
        }
    }
}
