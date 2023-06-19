using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSeniors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSeniors(new string[] { "9751302862F0693", "3888560693F7262",
                "5485983835F0649", "2580974299F6042", "9976672161M6561", "0234451011F8013",
                "4294552179O6482" }));
            Console.WriteLine(CountSeniors(new string[] { "7868190130M7522", "5303914400F9211", "9273338290F4010" }));
            Console.WriteLine(CountSeniors(new string[] { "1313579440F2036", "2921522980M5644" }));
            Console.WriteLine(CountSeniors(new string[] { "5612624052M0130", "5378802576M6424", "5447619845F0171", "2941701174O9078" }));
        }

        public static int CountSeniors(string[] details)
        {
            int counter = 0;

            // index 11 12
            foreach (var item in details)
            {
                if (item[11] == '6' || item[11] == '7' || item[11] == '8' || item[11] == '9')
                {
                    if (item[11] == '6' && item[12] == '0')
                        continue;

                    if (item[10] == 'F' || item[10] == 'M' || item[10] == 'O')
                        counter++;

                }
            }

            return counter;
        }
    }
}
