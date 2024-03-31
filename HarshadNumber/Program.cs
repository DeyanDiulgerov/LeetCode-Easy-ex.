using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarshadNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HarshadNumber(18));
            Console.WriteLine(HarshadNumber(23));
        }
        public static int HarshadNumber(int x)
        {
            string strX = x.ToString();
            int sum = 0;
            for (int i = 0; i < strX.Length; i++)
                sum += strX[i] - 48;
            return x % sum == 0 ? sum : -1;
        }
    }
}
