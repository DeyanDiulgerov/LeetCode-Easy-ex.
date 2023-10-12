using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfTheNumberIsFascinating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfTheNumberIsFascinating(192));
            Console.WriteLine(CheckIfTheNumberIsFascinating(100));
        }

        public static bool CheckIfTheNumberIsFascinating(int n)
        {
            var textNum = n.ToString();

            textNum += (n * 2).ToString();
            textNum += (n * 3).ToString();

            textNum = String.Concat(textNum.OrderBy(x => x));

            if (textNum == "123456789")
                return true;
            else
                return false;
        }
    }
}
