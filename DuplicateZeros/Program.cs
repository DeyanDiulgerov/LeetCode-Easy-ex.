using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateZeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", DuplicateZeros(new int[] { 8, 4, 5, 0, 0, 0, 0, 7 })));
            Console.WriteLine(String.Join(",", DuplicateZeros(new int[] { 0, 0, 0, 0, 0, 0 })));
            Console.WriteLine(String.Join(",", DuplicateZeros(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 })));
            Console.WriteLine(String.Join(",", DuplicateZeros(new int[] { 1, 2, 3 })));
        }

        public static int[] DuplicateZeros(int[] arr)
        {
            if (!arr.Any(x => x == 0))
                return arr;
            if (arr.All(x => x == 0))
                return arr;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0 && i < arr.Length - 1)
                {
                    var temp = arr[i + 1];
                    arr[i + 1] = 0;
                    for (int j = arr.Length - 1; j >= i + 2; j--)
                    {
                        if (j == i + 2)
                            arr[j] = temp;
                        else
                            arr[j] = arr[j - 1];
                        //Console.WriteLine(String.Join(",", arr));
                    }
                    i++;
                }
            }
            return arr;
        }
    }
}
