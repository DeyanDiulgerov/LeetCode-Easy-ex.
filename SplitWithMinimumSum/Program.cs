using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWithMinimumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SplitWithMinimumSum(4325));
            Console.WriteLine(SplitWithMinimumSum(687));
        }

        public static int SplitWithMinimumSum(int num)
        {
            var ChNum = num.ToString().ToCharArray();
            Array.Sort(ChNum);
            var first = "";
            var second = "";

            for (int i = 0; i < ChNum.Length; i += 2)
                first += ChNum[i];
            for (int i = 1; i < ChNum.Length; i += 2)
                second += ChNum[i];

            return int.Parse(first) + int.Parse(second);
        }
    }
}
