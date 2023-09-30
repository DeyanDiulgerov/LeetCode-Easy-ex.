using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimGame
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine(NimGame(7));
            Console.WriteLine(NimGame(5));
            Console.WriteLine(NimGame(4));
            Console.WriteLine(NimGame(1));
        }

        public static bool NimGame(int n)
        {
            if (n <= 3)
                return true;
            if (n % 4 != 0)
                return true;
            else
                return false;
        }
    }
}
