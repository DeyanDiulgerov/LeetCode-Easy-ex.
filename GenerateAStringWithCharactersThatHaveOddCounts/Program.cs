using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAStringWithCharactersThatHaveOddCounts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenerateAStringWithCharactersThatHaveOddCounts(1));
            Console.WriteLine(GenerateAStringWithCharactersThatHaveOddCounts(4));
            Console.WriteLine(GenerateAStringWithCharactersThatHaveOddCounts(2));
            Console.WriteLine(GenerateAStringWithCharactersThatHaveOddCounts(7));
        }

        public static string GenerateAStringWithCharactersThatHaveOddCounts(int n)
        {
            if (n == 1)
                return "a";
            var result = "";

            if (n % 2 == 0)
            {
                for (int i = 0; i < n - 1; i++)
                    result += 'a';

                result += 'b';
            }
            else
            {
                for (int i = 0; i < n - 2; i++)
                    result += 'a';

                result += 'b';
                result += 'c';
            }
            return result;
        }
    }
}
