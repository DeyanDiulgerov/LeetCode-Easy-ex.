using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumValueOfStringInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumValueOfStringInArray(new string[] { "5232", "yv", "22", "c", "yawgs", "928", "4003", "2" }));
            Console.WriteLine(MaximumValueOfStringInArray(new string[] { "alic3", "bob", "3", "4", "00000" }));
            Console.WriteLine(MaximumValueOfStringInArray(new string[] { "1", "01", "001", "0001" }));
        }

        public static int MaximumValueOfStringInArray(string[] strs)
        {
            bool hasLetter = false;
            string newNum = "";
            var max = 0.0;

            foreach (var item in strs)
            {
                var charred = item.ToString().ToCharArray();
                newNum = "";

                for (int i = 0; i < charred.Length; i++)
                {
                    if (char.IsLetter(charred[i]))
                    {
                        hasLetter = true;
                        newNum = "";
                        break;
                    }
                    else
                        hasLetter = false;
                }

                if (hasLetter)
                    max = Math.Max(max, item.Length);
                else
                {
                    for (int i = 0; i < charred.Length; i++)
                    {
                        newNum += charred[i];
                        max = Math.Max(max, int.Parse(newNum));
                    }
                }
            }

            return (int)max;
        }
    }
}
