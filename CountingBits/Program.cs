using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", CountingBits(2)));
            Console.WriteLine(String.Join(",", CountingBits(5)));
        }

        public static int[] CountingBits(int n)
        {
            var resultArr = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                int counter = 0;

                string str = Convert.ToString(i, 2);
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == '1')
                        counter++;
                }

                resultArr[i] = counter;
            }

            return resultArr;
        }
    }
}
