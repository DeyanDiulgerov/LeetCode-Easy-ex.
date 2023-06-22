using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinDeletionSize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", MinDeletionSize(new string[] { "cba", "daf", "ghi" })));
            Console.WriteLine(String.Join(",", MinDeletionSize(new string[] { "a", "b" })));
            Console.WriteLine(String.Join(",", MinDeletionSize(new string[] { "zyx", "wvu", "tsr" })));
        }

        public static int MinDeletionSize(string[] strs)
        {
            int columnDel = 0;
            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 0; j < strs.Length - 1; j++)
                {
                    if (strs[j][i] > strs[j + 1][i])
                    {
                        columnDel++;
                        break;
                    }
                }
            }
            return columnDel;
        }
    }
}
