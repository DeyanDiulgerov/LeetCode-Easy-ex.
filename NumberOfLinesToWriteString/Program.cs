using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfLinesToWriteString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", NumberOfLinesToWriteString(
                new int[] { 3, 4, 10, 4, 8, 7, 3, 3, 4, 9, 8, 2, 9, 6, 2, 8, 4,
                    9, 9, 10, 2, 4, 9, 10, 8, 2 }, "mqblbtpvicqhbrejb")));
            Console.WriteLine(String.Join(",", NumberOfLinesToWriteString(
                new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
                    10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, "abcdefghijklmnopqrstuvwxyz")));
            Console.WriteLine(String.Join(",", NumberOfLinesToWriteString(
                new int[] { 4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
                    10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, "bbbcccdddaaa")));
        }

        public static int[] NumberOfLinesToWriteString(int[] widths, string s)
        {
            int counter = 0;
            var letterAndWidthMap = new Dictionary<char, int>();
            var result = new int[2];

            for (int i = 97; i <= 122; i++)
            {
                letterAndWidthMap.Add(((char)i), widths[counter]);
                counter++;
            }

            counter = 0;
            var totalWidth = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (totalWidth + letterAndWidthMap[s[i]] > 100)
                {
                    counter++;
                    totalWidth = 0;
                    totalWidth += letterAndWidthMap[s[i]];
                }
                else
                    totalWidth += letterAndWidthMap[s[i]];
            }
            result[0] = counter + 1;
            result[1] = totalWidth;
            return result;
        }
    }
}
