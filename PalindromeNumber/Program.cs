using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PalindromeNumber(121));
            Console.WriteLine(PalindromeNumber(-121));
            Console.WriteLine(PalindromeNumber(10));
        }

        public static bool PalindromeNumber(int x)
        {
            var reversed = "";
            var chX = x.ToString();

            for (int i = chX.Length - 1; i >= 0; i--)
                reversed += chX[i];

            if (chX == reversed)
                return true;
            else
                return false;
        }
    }
}
