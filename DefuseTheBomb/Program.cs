using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefuseTheBomb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", DefuseTheBomb(new int[] { 5, 7, 1, 4 }, 3)));
            Console.WriteLine(String.Join(",", DefuseTheBomb(new int[] { 1, 2, 3, 4 }, 0)));
            Console.WriteLine(String.Join(",", DefuseTheBomb(new int[] { 2, 4, 9, 3 }, -2)));
        }

        public static int[] DefuseTheBomb(int[] code, int k)
        {
            var resultArr = new int[code.Length];

            if (k == 0)
            {
                var resultList = new List<int>();

                for (int i = 0; i < code.Length; i++)
                    resultList.Add(0);

                return resultList.ToArray();
            }
            else if (k > 0)
            {
                for (int i = 0; i < code.Length; i++)
                {
                    var sum = 0;
                    int counter = 0;

                    for (int j = i + 1; counter != k; j++)
                    {
                        if (j == code.Length)
                            j = 0;

                        sum += code[j];
                        counter++;
                    }

                    resultArr[i] = sum;
                }
            }
            else
            {
                for (int i = 0; i < code.Length; i++)
                {
                    var sum = 0;
                    int counter = 0;

                    for (int j = i - 1; counter != k; j--)
                    {
                        if (j < 0)
                            j = code.Length - 1;

                        sum += code[j];
                        counter--;
                    }

                    resultArr[i] = sum;
                }
            }

            return resultArr;
        }
    }
}
