using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfBitChangesToMakeTwoIntegersEqual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfBitChangesToMakeTwoIntegersEqual(2, 47));
            Console.WriteLine(NumberOfBitChangesToMakeTwoIntegersEqual(13, 4));
            Console.WriteLine(NumberOfBitChangesToMakeTwoIntegersEqual(21, 21));
            Console.WriteLine(NumberOfBitChangesToMakeTwoIntegersEqual(14, 13));
        }
        public static int NumberOfBitChangesToMakeTwoIntegersEqual(int n, int k)
        {
            string binaryN = Convert.ToString(n, 2);
            string binaryK = Convert.ToString(k, 2);
            bool isNBigger = false;
            int diff = 0;
            if (binaryN.Length >= binaryK.Length)
            {
                diff = binaryN.Length - binaryK.Length;
                isNBigger = true;
            }
            else
                diff = binaryK.Length - binaryN.Length;

            string insertion = "";
            for (int i = 0; i < diff; i++)
                insertion = insertion += "0";

            if (isNBigger == true)
                binaryK = binaryK.Insert(0, insertion);
            else
                binaryN = binaryN.Insert(0, insertion);
            Console.WriteLine(binaryN);
            Console.WriteLine(binaryK);

            int res = 0;
            for (int i = 0; i < binaryK.Length; i++)
            {
                if (binaryK[i] == '1' && binaryN[i] == '1')
                    continue;
                else if (binaryK[i] == '0' && binaryN[i] == '1')
                    res++;
                else if (binaryK[i] == '1' && binaryN[i] == '0')
                {
                    res = -1;
                    break;
                }
            }
            return res;
        }
    }
}
