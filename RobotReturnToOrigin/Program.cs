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
            var map = new Dictionary<char, int>()
            {
                {'U', 0},
                {'D', 0},
                {'L', 0},
                {'R', 0},
            };
            for(int i = 0; i < moves.Length; i++)
                map[moves[i]]++;
            return map['U'] == map['D'] && map['L'] == map['R'];
        }
    }
}
