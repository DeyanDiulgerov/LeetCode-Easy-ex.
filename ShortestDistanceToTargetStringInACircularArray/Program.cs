using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestDistanceToTargetStringInACircularArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ShortestDistanceToTargetStringInACircularArray(
              new string[]
              { "hsdqinnoha", "mqhskgeqzr", "zemkwvqrww", "zemkwvqrww", "daljcrktje",
                   "fghofclnwp", "djwdworyka", "cxfpybanhd", "fghofclnwp", "fghofclnwp" },
              "zemkwvqrww", 8));
            Console.WriteLine(ShortestDistanceToTargetStringInACircularArray(
                new string[] { "hello", "i", "am", "leetcode", "hello" }, "hello", 1));
            Console.WriteLine(ShortestDistanceToTargetStringInACircularArray(
                new string[] { "a", "b", "leetcode" }, "leetcode", 0));
            Console.WriteLine(ShortestDistanceToTargetStringInACircularArray(
                new string[] { "i", "eat", "leetcode" }, "ate", 0));
        }
        public static int ShortestDistanceToTargetStringInACircularArray(string[] words, string target, int startIndex)
        {
            if (!words.Contains(target))
                return -1;

            int n = words.Length;
            int leftCount = 0, rightCount = 0;
            bool isRepeated = false;

            for (int r = startIndex; r < n; r++)
            {
                if (words[r] == target)
                    break;
                if (r == startIndex && isRepeated)
                    break;
                if (r == n - 1)
                {
                    isRepeated = true;
                    r = 0;
                    r--;
                }

                rightCount++;
            }

            isRepeated = false;
            for (int l = startIndex; l >= 0; l--)
            {
                if (words[l] == target)
                    break;
                if (l == startIndex && isRepeated)
                    break;
                if (l == 0)
                {
                    isRepeated = true;
                    l = n - 1;
                    l++;
                }

                leftCount++;
            }

            return Math.Min(leftCount, rightCount);
        }
    }
}
