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
            var map = new Dictionary<int, string>();
            var listed = new List<int>(score);
            listed.Sort();
            var places = new List<string>()
            {"Gold Medal", "Silver Medal", "Bronze Medal"};
            for(int i = 3; i < score.Length; i++)
                places.Add((i + 1).ToString());
            int counterPlace = 0;
            for(int i = listed.Count - 1; i >= 0; i--)
            {
                int index = Array.IndexOf(score, listed[i]);
                map.Add(index, places[counterPlace]);
                counterPlace++;
            }
            string[] res = new string[score.Length];
            foreach(var kvp in map)
                res[kvp.Key] = kvp.Value;
            return res;
        }
    }
}
