using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheMaximumAchievableNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheMaximumAchievableNumber(4, 1));
            Console.WriteLine(FindTheMaximumAchievableNumber(3, 2));
        }

        public static int FindTheMaximumAchievableNumber(int num, int t)
            => num + (t * 2);
    }
}
