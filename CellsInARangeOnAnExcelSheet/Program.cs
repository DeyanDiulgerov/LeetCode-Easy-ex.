using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellsInARangeOnAnExcelSheet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", CellsInARangeOnAnExcelSheet("K1:L2")));
            Console.WriteLine(String.Join(",", CellsInARangeOnAnExcelSheet("A1:F1")));
        }

        public static IList<string> CellsInARangeOnAnExcelSheet(string s)
        {
            var result = new List<string>();

            for (char letter = s[0]; letter <= s[3]; letter++)
                for (char num = s[1]; num <= s[4]; num++)
                    result.Add($"{letter}{num}");

            return result;
        }
    }
}
