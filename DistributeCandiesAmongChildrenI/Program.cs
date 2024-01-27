using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeCandiesAmongChildrenI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DistributeCandiesAmongChildrenI(5, 2));
            Console.WriteLine(DistributeCandiesAmongChildrenI(3, 3));
        }
        public static int DistributeCandiesAmongChildrenI(int n, int limit)
        {
            int count = 0;
            for (int i = 0; i <= limit; i++)
            {
                for (int j = 0; j <= limit; j++)
                {
                    for (int k = 0; k <= limit; k++)
                    {
                        if (i + k + j == n)
                            count++;
                    }
                }
            }
            return count;
        }
    }
}
