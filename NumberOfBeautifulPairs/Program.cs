using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfBeautifulPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfBeautifulPairs(new int[] { 84, 91, 18, 59, 27, 9, 81, 33, 17, 58 }));
            Console.WriteLine(NumberOfBeautifulPairs(new int[] { 31, 25, 72, 79, 74 }));
            Console.WriteLine(NumberOfBeautifulPairs(new int[] { 2, 5, 1, 4 }));
            Console.WriteLine(NumberOfBeautifulPairs(new int[] { 11, 21, 12 }));
        }

        public static int NumberOfBeautifulPairs(int[] nums)
        {
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var toStrI = nums[i].ToString().ToCharArray();
                    var first = toStrI.First() - 48;
                    var toStrJ = nums[j].ToString().ToCharArray();
                    var second = toStrJ.Last() - 48;

                    bool canCount = true;
                    for (int n = 2; n <= 9; n++)
                    {
                        if (first % n == 0 && second % n == 0)
                        {
                            canCount = false;
                            break;
                        }
                    }
                    if (canCount)
                        counter++;
                }
            }
            return counter;
        }
    }
}
