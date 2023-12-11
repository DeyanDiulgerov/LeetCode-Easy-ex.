using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfStringsCanBeMadeEqualWithOperationsI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfStringsCanBeMadeEqualWithOperationsI("abcd", "cdab"));
            Console.WriteLine(CheckIfStringsCanBeMadeEqualWithOperationsI("abcd", "dacb"));
        }

        public static bool CheckIfStringsCanBeMadeEqualWithOperationsI(string s1, string s2)
        {
            var allS1Possibilites = new List<string>();
            var allS2Possibilites = new List<string>();
            var newS1 = s1.ToCharArray();
            var newS2 = s2.ToCharArray();
            string perm1 = s1;
            string perm2 = s2;
            allS1Possibilites.Add(s1);
            allS2Possibilites.Add(s2);

            var temp = newS1[0];
            newS1[0] = newS1[2];
            newS1[2] = temp;
            allS1Possibilites.Add(String.Concat(newS1));
            newS1 = perm1.ToCharArray();

            temp = newS1[1];
            newS1[1] = newS1[3];
            newS1[3] = temp;
            allS1Possibilites.Add(String.Concat(newS1));
            newS1 = perm1.ToCharArray();

            temp = newS2[0];
            newS2[0] = newS2[2];
            newS2[2] = temp;
            allS2Possibilites.Add(String.Concat(newS2));
            newS2 = perm2.ToCharArray();

            temp = newS2[1];
            newS2[1] = newS2[3];
            newS2[3] = temp;
            allS2Possibilites.Add(String.Concat(newS2));
            newS2 = perm2.ToCharArray();

            return allS1Possibilites.Any(x => allS2Possibilites.Contains(x));
        }
    }
}
