using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetermineTheWinnerOfABowlingGames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DetermineTheWinnerOfABowlingGames(
               new int[] { 3, 10, 9, 9 },
               new int[] { 8, 10, 2, 10 }));
            Console.WriteLine(DetermineTheWinnerOfABowlingGames(
                new int[] { 7, 10, 2, 6, 8, 5, 4, 6, 10, 9, 1, 4, 3, 10, 0, 9, 6, 1, 0 },
                new int[] { 2, 1, 9, 4, 5, 0, 6, 5, 6, 10, 10, 4, 8, 8, 6, 9, 2, 9, 5 }));
            Console.WriteLine(DetermineTheWinnerOfABowlingGames(
                new int[] { 9, 7, 10, 7 }, new int[] { 10, 2, 4, 10 }));
            Console.WriteLine(DetermineTheWinnerOfABowlingGames(
                new int[] { 4, 10, 7, 9 }, new int[] { 6, 5, 2, 3 }));
            Console.WriteLine(DetermineTheWinnerOfABowlingGames(
                new int[] { 3, 5, 7, 6 }, new int[] { 8, 10, 10, 2 }));
            Console.WriteLine(DetermineTheWinnerOfABowlingGames(
               new int[] { 2, 3 }, new int[] { 4, 1 }));
        }

        public static int DetermineTheWinnerOfABowlingGames(int[] player1, int[] player2)
        {
            int sumP1 = 0;
            int sumP2 = 0;
            int n = player1.Length;
            var addedPointsIndex = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (player1[i] == 10)
                {
                    if (!addedPointsIndex.Contains(i))
                        sumP1 += 10;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (j == i + 3)
                            break;

                        if (!addedPointsIndex.Contains(j))
                        {
                            sumP1 += player1[j] * 2;
                            addedPointsIndex.Add(j);
                        }
                    }
                }
                else
                {
                    if (!addedPointsIndex.Contains(i))
                    {
                        sumP1 += player1[i];
                        addedPointsIndex.Add(i);
                    }
                }
            }

            addedPointsIndex = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (player2[i] == 10)
                {
                    if (!addedPointsIndex.Contains(i))
                        sumP2 += 10;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (j == i + 3)
                            break;

                        if (!addedPointsIndex.Contains(j))
                        {
                            sumP2 += player2[j] * 2;
                            addedPointsIndex.Add(j);
                        }
                    }
                }
                else
                {
                    if (!addedPointsIndex.Contains(i))
                    {
                        sumP2 += player2[i];
                        addedPointsIndex.Add(i);
                    }
                }
            }

            Console.WriteLine(sumP1);
            Console.WriteLine(sumP2);

            if (sumP1 == sumP2)
                return 0;
            else if (sumP1 > sumP2)
                return 1;
            else
                return 2;
        }
    }
}
