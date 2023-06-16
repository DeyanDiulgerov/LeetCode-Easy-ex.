using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelColumnNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ExcelColumnNumber("A"));
            Console.WriteLine(ExcelColumnNumber("AB"));
            Console.WriteLine(ExcelColumnNumber("BA"));
            Console.WriteLine(ExcelColumnNumber("ZY"));
        }

        public static int ExcelColumnNumber(string columnTitle)
        {
            int output = 0;

            for (int i = 0; i < columnTitle.Length; i++)
            {
                int curr = columnTitle[i] - 'A' + 1;
                output = output * 26 + curr;
            }

            return output;
        }
    }
}
