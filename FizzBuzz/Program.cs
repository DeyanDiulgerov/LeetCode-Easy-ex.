using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Join(",", FizzBuzz(n)));
        }

        public static IList<string> FizzBuzz(int n)
        {
            List<string> res = new List<string>();
            for(int i = 1; i <= n; i++)
            {
                StringBuilder sb = new StringBuilder();
                if(i % 3 == 0)
                    sb.Append("Fizz");
                if(i % 5 == 0)
                    sb.Append("Buzz");
                if(sb.Length == 0)
                    sb.Append(i.ToString());
                res.Add(sb.ToString());
            }
            return res;
        }
    }
}
