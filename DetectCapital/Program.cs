using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectCapital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DetectCapital("USE"));
            Console.WriteLine(DetectCapital("FlaG"));
        }

        public static bool DetectCapital(string word)
        {
            if (word.All(x => char.IsUpper(x)) || word.All(x => char.IsLower(x)))
                return true;

            word = word.Remove(0, 1);
            if (word.All(x => char.IsLower(x)))
                return true;
            else
                return false;
        }
    }
}
