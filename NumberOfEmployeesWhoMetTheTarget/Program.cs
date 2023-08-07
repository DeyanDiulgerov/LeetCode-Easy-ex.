using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfEmployeesWhoMetTheTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfEmployeesWhoMetTheTarget(new int[] { 0, 1, 2, 3, 4 }, 2));
            Console.WriteLine(NumberOfEmployeesWhoMetTheTarget(new int[] { 5, 1, 4, 2, 2 }, 6));
        }

        public static int NumberOfEmployeesWhoMetTheTarget(int[] hours, int target)
        {
            int counter = 0;

            for (int i = 0; i < hours.Length; i++)
            {
                if (hours[i] >= target)
                    counter++;
            }

            return counter;
        }
    }
}
