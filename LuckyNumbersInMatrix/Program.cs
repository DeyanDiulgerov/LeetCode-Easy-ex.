using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbersInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix1 = new int[][]
            {
                new int[] {3,7,8},
                new int[] {9,11,13},
                new int[] {15,16,17},
            };

            var matrix2 = new int[][]
            {
                new int[] {1,10,4,2},
                new int[] {9,3,8,7},
                new int[] {15,16,17,12},
            };

            var matrix3 = new int[][]
            {
                new int[] {7,8},
                new int[] {1,2},
            };

            var matrix4 = new int[][]
            {
                new int[] {3,6},
                new int[] {7,1},
                new int[] {5,2},
                new int[] {4,8},
            };

            var matrix5 = new int[][]
            {
                new int[] {56216},
                new int[] {63251},
                new int[] {75772},
                new int[] {1945},
                new int[] {27014},
            };

            var matrix6 = new int[][]
            {
                new int[] {57849,12931,54418,4630,371},
                new int[] {57486,70179,8512,6629,45828},
            };

            Console.WriteLine(String.Join(",", LuckyNumbersInMatrix(matrix4)));
            Console.WriteLine(String.Join(",", LuckyNumbersInMatrix(matrix6)));
            Console.WriteLine(String.Join(",", LuckyNumbersInMatrix(matrix1)));
            Console.WriteLine(String.Join(",", LuckyNumbersInMatrix(matrix2)));
            Console.WriteLine(String.Join(",", LuckyNumbersInMatrix(matrix3)));
            Console.WriteLine(String.Join(",", LuckyNumbersInMatrix(matrix5)));
        }

        public static IList<int> LuckyNumbersInMatrix(int[][] matrix)
        {
            var answer = new List<int>();
            int num = 0;
            int biggest = 0;

            foreach (var item in matrix)
            {
                var newBig = item.Max();
                if (newBig > biggest)
                    biggest = newBig;
            }

            foreach (var item in matrix)
            {
                num = item.Max();
                if (biggest == num)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (item[i] < num)
                        {
                            num = item[i];
                            answer.Add(num);
                        }
                    }
                }
            }

            if (answer.Count == 0)
            {
                int max = num;
                foreach (var item in matrix)
                {
                    if (item.Max() > max)
                    {
                        max = item.Max();
                    }
                }
                return new List<int>() { max };
            }

            answer = new List<int>() { answer.Min() };

            var index = 0;

            foreach (var item in matrix)
            {
                var listed = new List<int>();

                foreach (var nummm in item)
                    listed.Add(nummm);


                if (item.Contains(answer.Min()))
                    index = listed.IndexOf(answer.Min());
                else
                    continue;
            }
            foreach (var item in matrix)
            {
                if (!item.Contains(answer.Min()))
                {
                    if (item[index] > answer.Min())
                    {
                        return new List<int>() { };
                    }
                }
            }

            return answer;
        }
    }
}
