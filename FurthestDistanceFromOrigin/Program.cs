using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurthestDistanceFromOrigin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FurthestDistanceFromOrigin("L_RL__R"));
            Console.WriteLine(FurthestDistanceFromOrigin("_R__LL_"));
            Console.WriteLine(FurthestDistanceFromOrigin("_______"));
        }

        public static int FurthestDistanceFromOrigin(string moves)
        {
            var leftCounter = 0;
            var rightCounter = 0;

            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'L')
                    leftCounter++;
                if (moves[i] == 'R')
                    rightCounter++;
            }

            var result = 0;
            var blankCount = moves.Count(x => x == '_');

            if (leftCounter > rightCounter)
                result = blankCount + leftCounter - rightCounter;
            else
                result = blankCount + rightCounter - leftCounter;

            return result;
        }
    }
}
