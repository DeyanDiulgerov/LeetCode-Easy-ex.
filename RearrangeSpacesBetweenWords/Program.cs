using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RearrangeSpacesBetweenWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RearrangeSpacesBetweenWords("a b   c d"));
            Console.WriteLine(RearrangeSpacesBetweenWords(" hello"));
            Console.WriteLine(RearrangeSpacesBetweenWords("a"));
            Console.WriteLine(RearrangeSpacesBetweenWords("  walks  udp package   into  bar a"));
            Console.WriteLine(RearrangeSpacesBetweenWords("hello   world"));
            Console.WriteLine(RearrangeSpacesBetweenWords("  this   is  a sentence "));
            Console.WriteLine(RearrangeSpacesBetweenWords(" practice   makes   perfect"));
        }

        public static string RearrangeSpacesBetweenWords(string text)
        {
            int spaceCount = 0;
            for (int i = 0; i < text.Length; i++)
                if (text[i] == ' ')
                    spaceCount++;

            if (spaceCount == 0)
                return text;

            text = text.Trim(' ');
            var splittedT = text.Split(' ').ToList();
            splittedT.RemoveAll(x => x == "");
            //Console.WriteLine(String.Join(",", splittedT));

            int modulus = 0;
            int divisor = 0;

            if (splittedT.Count() > 1)
                divisor = splittedT.Count() - 1;
            else
                divisor = 1;

            modulus = spaceCount % divisor;
            string result = "";
            if (modulus == 0)
            {
                string spaces = "";
                int length = spaceCount / divisor;
                for (int i = 0; i < length; i++)
                    spaces += " ";

                for (int i = 0; i < splittedT.Count(); i++)
                {
                    result += splittedT[i];
                    if (i != divisor)
                        result += spaces;
                }
            }
            else
            {
                string spaces = "";
                int length = spaceCount / divisor;
                for (int i = 0; i < length; i++)
                    spaces += " ";

                for (int i = 0; i < splittedT.Count(); i++)
                {
                    result += splittedT[i];
                    if (i != divisor)
                        result += spaces;
                    else
                    {
                        for (int j = 0; j < spaceCount; j++)
                        {
                            result += " ";
                        }
                    }

                    spaceCount -= spaces.Length;
                }
            }

            return result;
        }
    }
}
