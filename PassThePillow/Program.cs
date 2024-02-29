using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassThePillow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PassThePillow(4, 5));
            Console.WriteLine(PassThePillow(3, 2));
        }
        public static int PassThePillow(int n, int time)
        {
            int count = 1;
            bool shouldReverse = false;
            while (time > 0)
            {
                if (count == n)
                    shouldReverse = true;
                else if (count == 1)
                    shouldReverse = false;
                if (shouldReverse)
                    count--;
                else
                    count++;

                time--;
            }
            return count;
        }
    }
}
