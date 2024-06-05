using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCommonCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FindCommonCharacters(
                new string[] { "cool", "lock", "cook" })));
            Console.WriteLine(String.Join(",", FindCommonCharacters(
                new string[] { "bella", "label", "roller" })));
        }

        public static IList<string> FindCommonCharacters(string[] words)
        {
            string shortest = words.OrderBy(x => x.Length).First();
            var res = new List<string>();
            for(int i = 0; i < shortest.Length; i++)
            {
                if(words.All(x => x.Contains(shortest[i])))
                {
                    if(res.Contains(shortest[i].ToString()))
                    {
                        if(words.All(x => x.Count(z => z == shortest[i]) >= res.Count(x => x == shortest[i].ToString()) + 1))
                        {
                            res.Add(shortest[i].ToString());
                        }
                    }
                    else
                        res.Add(shortest[i].ToString());
                }
            }
            return res;
        }
    }
}
