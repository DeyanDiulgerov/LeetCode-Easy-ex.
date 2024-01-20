using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumDifferenceByRemappingADigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumDifferenceByRemappingADigit(99999));
            Console.WriteLine(MaximumDifferenceByRemappingADigit(11891));
            Console.WriteLine(MaximumDifferenceByRemappingADigit(90));
        }
        public static int MaximumDifferenceByRemappingADigit(int num)
        {
            if (num.ToString().All(x => x == '9'))
                return num;

            string str = num.ToString();
            string testMin = "";
            string testMax = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '0')
                {
                    testMin = str.Replace(str[i], '0');
                    break;
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '9')
                {
                    testMax = str.Replace(str[i], '9');
                    break;
                }
            }
            int max = int.Parse(testMax);
            int min = int.Parse(testMin);
            return max - min;
        }
    }
}
