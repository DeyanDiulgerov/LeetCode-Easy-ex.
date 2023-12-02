using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOfAKindInADeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(XOfAKindInADeckOfCards(new int[] { 0, 0, 0, 0, 0, 1, 1, 2, 3, 4 }));
            Console.WriteLine(XOfAKindInADeckOfCards(new int[] { 1, 1, 1, 1, 2, 2, 2, 2, 2, 2 }));
            Console.WriteLine(XOfAKindInADeckOfCards(new int[] { 0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 2, 2, 3, 3, 3 }));
            Console.WriteLine(XOfAKindInADeckOfCards(new int[] { 1, 1, 1, 1, 2, 2, 2, 2, 2, 2 }));
            Console.WriteLine(XOfAKindInADeckOfCards(new int[] { 1, 1, 2, 2, 2, 2 }));
            Console.WriteLine(XOfAKindInADeckOfCards(new int[] { 1 }));
            Console.WriteLine(XOfAKindInADeckOfCards(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }));
            Console.WriteLine(XOfAKindInADeckOfCards(new int[] { 1, 1, 1, 2, 2, 2, 3, 3 }));
        }
        public static bool XOfAKindInADeckOfCards(int[] deck)
        {
            if (deck.Length == 1 && deck[0] == 1)
                return false;
            var numAndOccurrenceMap = new Dictionary<int, int>();
            int n = deck.Length;

            for (int i = 0; i < n; i++)
            {
                if (!numAndOccurrenceMap.ContainsKey(deck[i]))
                    numAndOccurrenceMap.Add(deck[i], 1);
                else
                    numAndOccurrenceMap[deck[i]]++;
            }
            for (int i = 2; i < 20; i++)
            {
                if (numAndOccurrenceMap.Values.All(x => x % i == 0))
                    return true;
            }
            return false;
        }
    }
}
