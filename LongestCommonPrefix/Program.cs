using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            while (command != "End")
            {
                var strs = command.Split(',').ToArray();
                Console.WriteLine(LongestCommonPrefix(strs));
                command = Console.ReadLine();
            }
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            int counter = 0;
            var sb = new StringBuilder();

            var shortest = s.OrderBy(x => x.Length).First();

            foreach (var letter in shortest)
            {
                if (s.Any(x => x[counter] != letter))
                    break;

                sb.Append(letter);
                counter++;
            }

            return sb.ToString();
        }
    }
}
