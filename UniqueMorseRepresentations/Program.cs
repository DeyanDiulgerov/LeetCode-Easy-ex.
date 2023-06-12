using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueMorseRepresentations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UniqueMorseRepresentations(new string[] { "rwjje", "aittjje", "auyyn", "lqtktn", "lmjwn" }));
            Console.WriteLine(UniqueMorseRepresentations(new string[] { "gin", "zen", "gig", "msg" }));
            Console.WriteLine(UniqueMorseRepresentations(new string[] { "a" }));
        }

        public static int UniqueMorseRepresentations(string[] words)
        {
            if (words.Count() == 1)
                return 1;

            string[] result = new string[] { };
            string newResult = "";

            var dictionary = new Dictionary<char, string>()
            {
                {'a',".-"},
                {'b',"-..."},
                {'c',"-.-."},
                {'d',"-.."},
                {'e',"."},
                {'f',"..-."},
                {'g',"--."},
                {'h',"...."},
                {'i',".."},
                {'j',".---"},
                {'k',"-.-"},
                {'l',".-.."},
                {'m',"--"},
                {'n',"-."},
                {'o',"---"},
                {'p',".--."},
                {'q',"--.-"},
                {'r',".-."},
                {'s',"..."},
                {'t',"-"},
                {'u',"..-"},
                {'v',"...-"},
                {'w',".--"},
                {'x',"-..-"},
                {'y',"-.--"},
                {'z',"--.."},
            };

            var listed = new List<string>(result);

            for (int i = 0; i < words.Count(); i++)
            {
                foreach (var letter in words[i])
                {
                    newResult += dictionary[letter];
                }
                Console.WriteLine(newResult);
                listed.Add(newResult);
                newResult = "";
            }

            return listed.Distinct().Count();
        }
    }
}
