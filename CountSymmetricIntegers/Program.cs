using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSymmetricIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSymmetricIntegers(1229, 1230));
            Console.WriteLine(CountSymmetricIntegers(1200, 1230));
            Console.WriteLine(CountSymmetricIntegers(1, 100));
        }

        public static int CountSymmetricIntegers(int low, int high)
        {
            var allIntegers = new List<int>();

            for (int i = low; i <= high; i++)
            {
                var strNum = i.ToString();
                if (strNum.Length % 2 != 0)
                    continue;

                int n = strNum.Length / 2;
                int jSum = 0;
                int kSum = 0;

                for (int j = 0; j < n; j++)
                    jSum += strNum[j] - 48;
                for (int k = n; k < strNum.Length; k++)
                    kSum += strNum[k] - 48;

                if (jSum == kSum)
                    allIntegers.Add(i);
            }

            return allIntegers.Count();
        }
    }
}
