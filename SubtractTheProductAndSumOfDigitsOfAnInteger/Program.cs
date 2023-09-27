using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtractTheProductAndSumOfDigitsOfAnInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SubtractTheProductAndSumOfDigitsOfAnInteger(234));
            Console.WriteLine(SubtractTheProductAndSumOfDigitsOfAnInteger(4421));
        }

        public static int SubtractTheProductAndSumOfDigitsOfAnInteger(int n)
        {
            var stringN = n.ToString().ToCharArray();
            int multiple = stringN[0] - 48;
            int sum = stringN[0] - 48;

            for (int i = 1; i < stringN.Length; i++)
            {
                multiple *= stringN[i] - 48;
                sum += stringN[i] - 48;
            }

            return multiple - sum;
        }
    }
}
