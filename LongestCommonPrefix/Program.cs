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
            if (strs.Count() == 0 || strs.Count() == 1)
                return String.Join(",", strs);

            var shortest = strs.OrderBy(x => x.Length).First();
            var sb = new StringBuilder();
            var counter = 0;

            foreach (var letter in shortest)
            {
                if (strs.Any(x => x[counter] != shortest[counter]))
                    break;

                sb.Append(letter);
                counter++;
            }


            return sb.ToString();
        }
    }
}
