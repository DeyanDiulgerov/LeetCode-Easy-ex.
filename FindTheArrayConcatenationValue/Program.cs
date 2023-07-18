using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheArrayConcatenationValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheArrayConcatenationValue
                (new int[] { 72, 8, 96, 78, 39, 92, 69, 55, 9, 44, 26, 76, 40,
                    77, 16, 69, 40, 64, 12, 48, 66, 7, 59, 10, 33, 72, 97, 60,
                    79, 68, 25, 63, 82, 88, 60, 37, 60, 44, 14, 62 }));

            Console.WriteLine(FindTheArrayConcatenationValue(new int[] { 7, 52, 2, 4 }));
            Console.WriteLine(FindTheArrayConcatenationValue(new int[] { 5, 14, 13, 8, 12 }));
        }

        public static long FindTheArrayConcatenationValue(int[] nums)
        {
            int n = 0;
            if (nums.Length % 2 == 0)
                n = nums.Length / 2;
            else
                n = (nums.Length + 1) / 2;

            var listedNums = new List<int>(nums);
            long concatValue = 0;

            for (int i = 0; i < n; i++)
            {
                if (listedNums.Count() == 0)
                    break;
                else if (listedNums.Count >= 2)
                {
                    int first = listedNums.First();
                    int last = listedNums.Last();

                    string concat = first.ToString() + last.ToString();
                    concatValue += long.Parse(concat);

                    listedNums.Remove(first);

                    int lastIndex = listedNums.LastIndexOf(last);
                    listedNums.RemoveAt(lastIndex);
                }
                else if (listedNums.Count == 1)
                {
                    concatValue += listedNums.First();
                    listedNums.Remove(listedNums.Count());
                }
            }

            return concatValue;
        }
    }
}
