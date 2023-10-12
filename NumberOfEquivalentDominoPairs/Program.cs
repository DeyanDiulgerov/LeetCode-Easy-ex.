using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfEquivalentDominoPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var dominoes1 = new int[][]
            {
                new int[] {1,2},
                new int[] {2,1},
                new int[] {3,4},
                new int[] {5,6},
            };
            var dominoes2 = new int[][]
          {
                new int[] {1,2},
                new int[] {1,2},
                new int[] {1,1},
                new int[] {1,2},
                new int[] {2,2},
          };

            Console.WriteLine(NumberOfEquivalentDominoPairs(dominoes1));
            Console.WriteLine(NumberOfEquivalentDominoPairs(dominoes2));
        }

        public static int NumberOfEquivalentDominoPairs(int[][] dominoes)
        {
            int counter = 0;

            for (int i = 0; i < dominoes.Length; i++)
            {
                for (int j = i + 1; j < dominoes.Length; j++)
                {
                    if (dominoes[i][0] == dominoes[j][0] && dominoes[i][1] == dominoes[j][1]
                     || dominoes[i][0] == dominoes[j][1] && dominoes[i][1] == dominoes[j][0])
                        counter++;
                }
            }

            return counter;
        }
    }
}
