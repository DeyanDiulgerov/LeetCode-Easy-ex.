using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumOperationsToMakeArrayEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumOperationsToMakeArrayEqual(1)); //0
            Console.WriteLine(MinimumOperationsToMakeArrayEqual(2)); //1
            Console.WriteLine(MinimumOperationsToMakeArrayEqual(3)); //2
            Console.WriteLine(MinimumOperationsToMakeArrayEqual(4)); //4
            Console.WriteLine(MinimumOperationsToMakeArrayEqual(5)); //6
            Console.WriteLine(MinimumOperationsToMakeArrayEqual(6)); //9
            Console.WriteLine(MinimumOperationsToMakeArrayEqual(7)); //12
            Console.WriteLine(MinimumOperationsToMakeArrayEqual(8)); //16
            Console.WriteLine(MinimumOperationsToMakeArrayEqual(9)); //20
            Console.WriteLine(MinimumOperationsToMakeArrayEqual(10));//25
        }
        public static int MinimumOperationsToMakeArrayEqual(int n)
        {
            return n * n / 4;
        }
    }
}
