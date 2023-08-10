using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPokerHand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BestPokerHand(new int[] { 13, 2, 3, 1, 9 }, new char[] { 'a', 'a', 'a', 'a', 'a' }));
            Console.WriteLine(BestPokerHand(new int[] { 4, 4, 2, 4, 4 }, new char[] { 'd', 'a', 'a', 'b', 'c' }));
            Console.WriteLine(BestPokerHand(
                new int[] { 10, 10, 2, 12, 9 },
                new char[] { 'a', 'b', 'c', 'a', 'd' }));
        }

        public static string BestPokerHand(int[] ranks, char[] suits)
        {
            if (suits.All(x => x == suits[0]))
                return "Flush";
            else
            {
                var cardAndCount = new Dictionary<int, int>();

                for (int i = 0; i < ranks.Length; i++)
                {
                    if (!cardAndCount.ContainsKey(ranks[i]))
                        cardAndCount.Add(ranks[i], 1);
                    else
                        cardAndCount[ranks[i]]++;
                }

                var countOfCard = cardAndCount.OrderBy(x => x.Value).Last().Value;

                if (countOfCard >= 3)
                    return "Three of a Kind";
                else if (countOfCard == 2)
                    return "Pair";
                else
                    return "High Card";
            }
        }
    }
}
