using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfNAndItsDoubleExist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfNAndItsDoubleExist(new int[] { 10, 2, 5, 3 }));
            Console.WriteLine(CheckIfNAndItsDoubleExist(new int[] { 3, 1, 7, 11 }));
            Console.WriteLine(CheckIfNAndItsDoubleExist(new int[] { 7, 1, 14, 11 }));
        }

        public static bool CheckIfNAndItsDoubleExist(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == 2 * arr[j] && i != j)
                        return true;
                }
            }

            return false;
        }
    }
}
