using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinationCity
{
    class Program
    {
        static void Main(string[] args)
        {
            var paths1 = new List<IList<string>>();
            paths1.Add(new List<string>() { "London", "New York" });
            paths1.Add(new List<string>() { "New York", "Lima" });
            paths1.Add(new List<string>() { "Lima", "Sao Paulo" });

            var paths2 = new List<IList<string>>();
            paths2.Add(new List<string>() { "B", "C" });
            paths2.Add(new List<string>() { "D", "B" });
            paths2.Add(new List<string>() { "C", "A" });

            var paths3 = new List<IList<string>>();
            paths3.Add(new List<string>() { "A", "Z" });

            Console.WriteLine(DestinationCity(paths1));
            Console.WriteLine(DestinationCity(paths2));
            Console.WriteLine(DestinationCity(paths3));
        }

        public static string DestinationCity(IList<IList<string>> paths)
        {
            var startCities = new List<string>();
            var destinationCities = new List<string>();

            foreach (var item in paths)
            {
                startCities.Add(item[0]);
                destinationCities.Add(item[1]);
            }

            foreach (var item in destinationCities)
            {
                if (!startCities.Contains(item))
                    return item;
            }

            return "TEST";
        }
    }
}
