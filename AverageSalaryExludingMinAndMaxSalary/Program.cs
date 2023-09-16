using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageSalaryExludingMinAndMaxSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AverageSalaryExludingMinAndMaxSalary(new int[] { 48000, 59000, 99000, 13000, 78000, 45000, 31000, 17000, 39000, 37000, 93000, 77000, 33000, 28000, 4000, 54000, 67000, 6000, 1000, 11000 }));
            Console.WriteLine(AverageSalaryExludingMinAndMaxSalary(new int[] { 1000, 2000, 3000 }));
            Console.WriteLine(AverageSalaryExludingMinAndMaxSalary(new int[] { 4000, 3000, 1000, 2000 }));
        }

        public static double AverageSalaryExludingMinAndMaxSalary(int[] salary)
        {
            var listed = new List<int>(salary);

            listed.Sort();
            listed.Remove(listed.First());
            listed.Remove(listed.Last());

            double result = (double)listed.Sum() / (double)listed.Count();
            return double.Parse(result.ToString("N5"));
        }
    }
}
