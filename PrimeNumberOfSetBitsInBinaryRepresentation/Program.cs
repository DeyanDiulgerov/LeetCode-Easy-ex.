using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberOfSetBitsInBinaryRepresentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrimeNumberOfSetBitsInBinaryRepresentation(6, 10));
            Console.WriteLine(PrimeNumberOfSetBitsInBinaryRepresentation(10, 15));
            Console.WriteLine(PrimeNumberOfSetBitsInBinaryRepresentation(7, 19));
        }
        public static int PrimeNumberOfSetBitsInBinaryRepresentation(int left, int right)
        {
            var allPrimeNumbers = new List<int>()
            { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41,
              43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97};

            var result = 0;

            for (int i = left; i <= right; i++)
            {
                int counter = 0;
                var binary = Convert.ToString(i, 2);

                for (int j = 0; j < binary.Length; j++)
                    if (binary[j] == '1')
                        counter++;

                if (allPrimeNumbers.Contains(counter))
                    result++;
            }

            return result;
        }
    }
}
