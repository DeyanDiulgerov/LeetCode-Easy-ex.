using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumberAfterDigitSwapsByParity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestNumberAfterDigitSwapsByParity(1234));
            Console.WriteLine(LargestNumberAfterDigitSwapsByParity(65875));
        }
        public static int LargestNumberAfterDigitSwapsByParity(int num)
        {
            var test = num.ToString();

            for (int i = 0; i < test.Length; i++)
            {
                for (int j = i + 1; j < test.Length; j++)
                {
                    if (((int)test[i] % 2 == 0 && (int)test[j] % 2 == 0) ||
                         (int)test[i] % 2 != 0 && (int)test[j] % 2 != 0)
                    {
                        if (test[j] - 48 > test[i] - 48)
                        {
                            var permI = test[i];
                            var permJ = test[j];

                            test = test.Remove(i, 1);
                            test = test.Insert(i, permJ.ToString());
                            test = test.Remove(j, 1);
                            test = test.Insert(j, permI.ToString());
                        }
                    }
                }
            }
            return int.Parse(test);
        }
    }
}
