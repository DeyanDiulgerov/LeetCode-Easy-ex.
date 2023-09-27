using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTheTemperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", ConvertTheTemperature(36.50)));
            Console.WriteLine(String.Join(",", ConvertTheTemperature(122.11)));
        }

        public static double[] ConvertTheTemperature(double celsius)
        {
            double kelvin = celsius + 273.15;
            double fahrenheit = celsius * 1.80 + 32.00;
            return new double[] { kelvin, fahrenheit };
        }
    }
}
