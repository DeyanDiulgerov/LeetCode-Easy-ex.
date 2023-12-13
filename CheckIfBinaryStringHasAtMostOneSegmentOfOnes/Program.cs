using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfBinaryStringHasAtMostOneSegmentOfOnes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfBinaryStringHasAtMostOneSegmentOfOnes("1000"));
            Console.WriteLine(CheckIfBinaryStringHasAtMostOneSegmentOfOnes("10"));
            Console.WriteLine(CheckIfBinaryStringHasAtMostOneSegmentOfOnes("1"));
            Console.WriteLine(CheckIfBinaryStringHasAtMostOneSegmentOfOnes("1001"));
            Console.WriteLine(CheckIfBinaryStringHasAtMostOneSegmentOfOnes("110"));
        }

        public static bool CheckIfBinaryStringHasAtMostOneSegmentOfOnes(string s)
        {
            if (s.Length == 1)
                return s[0] == '1';
            int left = 0, right = 1;
            bool isSecond = false;
            bool isOnlyOneSegment = false;

            while (right < s.Length)
            {
                if (s[left] == '1' || s[right] == '1' && !isOnlyOneSegment)
                    isOnlyOneSegment = true;
                else if (s[left] == '1' || s[right] == '1' && isOnlyOneSegment)
                {
                    isOnlyOneSegment = false;
                    break;
                }

                if (s[left] == '1' && s[right] == '1' && !isSecond)
                    isSecond = true;
                else if (s[left] == '1' && s[right] == '1' && !isSecond)
                    return false;

                left++;
                right++;
            }

            return isOnlyOneSegment;
        }
    }
}
