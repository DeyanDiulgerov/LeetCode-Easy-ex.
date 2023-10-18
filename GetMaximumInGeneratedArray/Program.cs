using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMaximumInGeneratedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMaximumInGeneratedArray(0));
            Console.WriteLine(GetMaximumInGeneratedArray(7));
            Console.WriteLine(GetMaximumInGeneratedArray(2));
            Console.WriteLine(GetMaximumInGeneratedArray(3));
        }

        public static int GetMaximumInGeneratedArray(int n)
        {
            if (n == 0)
                return 0;
            var result = new int[n + 1];
            result[0] = 0;
            result[1] = 1;

            for (int i = 1; i < n; i++)
            {
                if (2 * i <= n)
                    result[2 * i] = result[i];
                if (2 * i + 1 <= n)
                    result[(2 * i) + 1] = result[i] + result[i + 1];
            }

            Console.WriteLine(String.Join(",", result));
            return result.Max();
        }
    }
}
