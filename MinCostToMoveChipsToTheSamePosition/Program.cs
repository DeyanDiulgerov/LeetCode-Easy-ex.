using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinCostToMoveChipsToTheSamePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinCostToMoveChipsToTheSamePosition(new int[] { 1, 2, 3 }));
            Console.WriteLine(MinCostToMoveChipsToTheSamePosition(new int[] { 2, 2, 2, 3, 3 }));
            Console.WriteLine(MinCostToMoveChipsToTheSamePosition(new int[] { 1, 1000000000 }));
        }
        public static int MinCostToMoveChipsToTheSamePosition(int[] position)
        {
            int even = 0;
            int odd = 0;

            for (int i = 0; i < position.Length; i++)
            {
                if (position[i] % 2 == 0)
                    even++;
                else
                    odd++;
            }

            return Math.Min(even, odd);
        }
    }
}
