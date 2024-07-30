using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindifDigitGameCanBeWon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindifDigitGameCanBeWon(new int[] { 1, 2, 3, 4, 10 }));
            Console.WriteLine(FindifDigitGameCanBeWon(new int[] { 1, 2, 3, 4, 5, 14 }));
            Console.WriteLine(FindifDigitGameCanBeWon(new int[] { 5, 5, 5, 25 }));
        }
        public static bool FindifDigitGameCanBeWon(int[] nums)
        {
            var map = new Dictionary<string, int>();
            map.Add("single", 0);
            map.Add("double", 0);
            foreach (int num in nums)
            {
                if (num >= 10)
                    map["double"] += num;
                else
                    map["single"] += num;
            }
            return map["double"] != map["single"];
        }
    }
}
