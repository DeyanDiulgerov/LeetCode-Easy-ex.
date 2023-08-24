using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisorGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DivisorGame(2));
            Console.WriteLine(DivisorGame(3));
        }

        public static bool DivisorGame(int n)
        {
            if (n % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
