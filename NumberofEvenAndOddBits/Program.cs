using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberofEvenAndOddBits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", NumberofEvenAndOddBits(17)));
            Console.WriteLine(String.Join(",", NumberofEvenAndOddBits(2)));
        }
        public static int[] NumberofEvenAndOddBits(int n)
        {
            string str = Convert.ToString(n, 2);
            str = String.Concat(str.Reverse());
            Console.WriteLine(str);
            int evenCount = 0, oddCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0 && i != 1 && str[i] == '1')
                    evenCount++;
                else if (i % 2 != 0 && str[i] == '1')
                    oddCount++;
            }
            return new int[] { evenCount, oddCount };
        }
    }
}
