using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfStepsToReduceANumberToZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfStepsToReduceNumberToZero(14));
            Console.WriteLine(NumberOfStepsToReduceNumberToZero(8));
            Console.WriteLine(NumberOfStepsToReduceNumberToZero(123));
        }

        public static int NumberOfStepsToReduceNumberToZero(int num)
        {
            int counter = 0;
            while (num != 0)
            {
                if (num % 2 == 0)
                    num /= 2;
                else
                    num -= 1;

                counter++;
            }
            return counter;
        }
    }
}
