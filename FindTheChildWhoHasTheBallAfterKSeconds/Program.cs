using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheChildWhoHasTheBallAfterKSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheChildWhoHasTheBallAfterKSeconds(3, 5));
            Console.WriteLine(FindTheChildWhoHasTheBallAfterKSeconds(5, 6));
            Console.WriteLine(FindTheChildWhoHasTheBallAfterKSeconds(4, 2));
        }
        public static int FindTheChildWhoHasTheBallAfterKSeconds(int n, int k)
        {
            int i = 0;
            while (k > 0)
            {
                if (i == n - 1)
                {
                    while (i > 0)
                    {
                        i--;
                        k--;
                        if (k == 0)
                            break;
                    }
                }
                else
                {
                    i++;
                    k--;
                    if (k == 0)
                        break;
                }
            }
            return i;
        }
    }
}
