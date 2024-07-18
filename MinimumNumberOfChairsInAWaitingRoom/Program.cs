using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumNumberOfChairsInAWaitingRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumNumberOfChairsInAWaitingRoom("EEEEEEE"));
            Console.WriteLine(MinimumNumberOfChairsInAWaitingRoom("ELELEEL"));
            Console.WriteLine(MinimumNumberOfChairsInAWaitingRoom("ELEELEELLL"));
            Console.WriteLine(MinimumNumberOfChairsInAWaitingRoom("EL"));
            Console.WriteLine(MinimumNumberOfChairsInAWaitingRoom("EEL"));
        }
        public static int MinimumNumberOfChairsInAWaitingRoom(string s)
        {
            int chairs = 0;
            int res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'E')
                    chairs++;
                else
                    chairs--;
                res = Math.Max(chairs, res);
            }
            return res;
        }
    }
}
