using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOperationsToObtainZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountOperationsToObtainZero(2, 3));
            Console.WriteLine(CountOperationsToObtainZero(10, 10));
        }

        public static int CountOperationsToObtainZero(int num1, int num2)
        {
            int counter = 0;

            while (num1 != 0 && num2 != 0)
            {
                if (num1 > num2)
                    num1 -= num2;
                else if (num2 > num1)
                    num2 -= num1;
                else
                {
                    counter++;
                    break;
                }
                counter++;
            }

            return counter;
        }
    }
}
