using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumRecolorsToGetKConsecutiveBlackBlocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumRecolorsToGetKConsecutiveBlackBlocks("WBBWWBBWBW", 7));
            Console.WriteLine(MinimumRecolorsToGetKConsecutiveBlackBlocks("WBWBBBW", 2));
        }

        public static int MinimumRecolorsToGetKConsecutiveBlackBlocks(string blocks, int k)
        {
            string substring = "";
            int min = int.MaxValue;

            for (int i = 0; i < k; i++)
                substring += blocks[i];

            int countBlack = substring.Count(x => x == 'B');
            min = Math.Min(min, k - countBlack);
            int right = k - 1;

            while (right < blocks.Length - 1)
            {
                if (substring[0] == 'B')
                    countBlack--;
                substring = substring.Remove(0, 1);
                right++;
                substring += blocks[right];
                if (blocks[right] == 'B')
                    countBlack++;

                min = Math.Min(min, k - countBlack);
            }
            return min;
        }
    }
}
