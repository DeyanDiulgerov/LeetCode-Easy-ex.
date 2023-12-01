using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReformatDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReformatDate("20th Oct 2052"));
            Console.WriteLine(ReformatDate("6th Jun 1933"));
            Console.WriteLine(ReformatDate("26th May 1960"));
        }
        public static string ReformatDate(string date)
        {
            var splitted = date.Split(' ').ToArray();
            var result = "";
            result += splitted.Last();

            var monthAndNumMap = new Dictionary<string, string>()
            {
                {"Jan", "01"},
                {"Feb", "02"},
                {"Mar", "03"},
                {"Apr", "04"},
                {"May", "05"},
                {"Jun", "06"},
                {"Jul", "07"},
                {"Aug", "08"},
                {"Sep", "09"},
                {"Oct", "10"},
                {"Nov", "11"},
                {"Dec", "12"},
            };

            result += "-" + monthAndNumMap[splitted[1]];
            var days = "";

            for (int i = 0; i < splitted[0].Length; i++)
            {
                if (Char.IsDigit(splitted[0][i]))
                    days += splitted[0][i].ToString();
                else
                    break;
            }

            if (days.Length == 1)
                days = days.Insert(0, "0");

            result += "-" + days;

            return result;
        }
    }
}
