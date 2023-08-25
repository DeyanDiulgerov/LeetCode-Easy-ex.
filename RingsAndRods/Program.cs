using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingsAndRods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RingsAndRods("B0B6G0R6R0R6G9"));
            Console.WriteLine(RingsAndRods("B0R0G0R9R0B0G0"));
            Console.WriteLine(RingsAndRods("G4"));
        }

        public static int RingsAndRods(string rings)
        {
            var rodAndColorsDict = new Dictionary<int, List<char>>();
            int resultCounter = 0;

            for (int i = 0; i < rings.Length; i++)
            {
                var color = rings[i];

                if (i < rings.Length - 1)
                {
                    var rod = rings[i + 1];

                    if (!rodAndColorsDict.ContainsKey(rod))
                        rodAndColorsDict.Add(rod, new List<char>() { color });
                    else
                        rodAndColorsDict[rod].Add(color);
                }
            }

            foreach (var kvp in rodAndColorsDict)
            {
                if (kvp.Value.Contains('B') && kvp.Value.Contains('G') && kvp.Value.Contains('R'))
                    resultCounter++;
            }
            return resultCounter;
        }
    }
}
