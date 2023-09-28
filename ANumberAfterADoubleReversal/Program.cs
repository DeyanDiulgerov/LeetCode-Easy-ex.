using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANumberAfterADoubleReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ANumberAfterADoubleReversal(526));
            Console.WriteLine(ANumberAfterADoubleReversal(1800));
            Console.WriteLine(ANumberAfterADoubleReversal(0));
        }

        public static bool ANumberAfterADoubleReversal(int num)
        {
            var strNum = num.ToString();
            var reversed1 = "";
            var reversed2 = "";

            for (int i = strNum.Length - 1; i >= 0; i--)
                reversed1 += strNum[i];

            var newReversed1 = int.Parse(reversed1);
            var strNew = newReversed1.ToString();

            for (int i = strNew.Length - 1; i >= 0; i--)
                reversed2 += strNew[i];

            var newReversed2 = int.Parse(reversed2);

            if (newReversed2 == num)
                return true;
            else
                return false;
        }
    }
}
