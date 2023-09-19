using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotReturnToOrigin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RobotReturnToOrigin("UD"));
            Console.WriteLine(RobotReturnToOrigin("LL"));
        }

        public static bool RobotReturnToOrigin(string moves)
        {
            var moveAndCountDict = new Dictionary<char, int>();

            moveAndCountDict.Add('L', 0);
            moveAndCountDict.Add('R', 0);
            moveAndCountDict.Add('U', 0);
            moveAndCountDict.Add('D', 0);

            for (int i = 0; i < moves.Length; i++)
                moveAndCountDict[moves[i]]++;

            if (moveAndCountDict['L'] == moveAndCountDict['R']
             && moveAndCountDict['D'] == moveAndCountDict['U'])
                return true;
            else
                return false;
        }
    }
}
