using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum69Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Maximum69Number(9669));
            Console.WriteLine(Maximum69Number(9996));
            Console.WriteLine(Maximum69Number(9999));
        }

        public static int Maximum69Number(int num)
        {
            var testNum = num.ToString();
            var listed = new List<int>();

            foreach (var numm in testNum)
                listed.Add(numm - 48);

            for (int i = 0; i < listed.Count(); i++)
            {
                if (listed[i] == 6)
                {
                    listed.RemoveAt(i);
                    listed.Insert(i, 9);
                    break;
                }
            }

            string result = "";
            foreach (var numm in listed)
                result += numm;

            return int.Parse(result);
        }
    }
}
