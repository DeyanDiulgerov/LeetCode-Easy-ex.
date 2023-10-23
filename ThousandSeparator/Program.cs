using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThousandSeparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ThousandSeparator(987));
            Console.WriteLine(ThousandSeparator(1234));
            Console.WriteLine(ThousandSeparator(12345));
            Console.WriteLine(ThousandSeparator(2120345));
        }

        public static string ThousandSeparator(int n)
        {
            var str = n.ToString();
            int counter = 1;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (counter == 3 && i != 0)
                {
                    str = str.Insert(i, ".");
                    counter = 0;
                }

                counter++;
            }

            return str;
        }
    }
}
