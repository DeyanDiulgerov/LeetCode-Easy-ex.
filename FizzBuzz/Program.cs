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
            var buzzed = new List<string>();

            for (int i = 0; i <= n; i++)
            {
                if (i != 0)
                {
                    if (i % 5 == 0 && i % 3 == 0)
                        buzzed.Add("FizzBuzz");
                    else if (i % 3 == 0)
                        buzzed.Add("Fizz");
                    else if (i % 5 == 0)
                        buzzed.Add("Buzz");
                    else
                        buzzed.Add(i.ToString());
                }
            }

            Console.WriteLine(String.Join(",", buzzed));
            return buzzed;
        }
    }
}
