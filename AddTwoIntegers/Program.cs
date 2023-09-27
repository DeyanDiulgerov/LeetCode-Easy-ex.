using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddTwoIntegers(12, 5));
            Console.WriteLine(AddTwoIntegers(-10, 4));
        }

        public static int AddTwoIntegers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
