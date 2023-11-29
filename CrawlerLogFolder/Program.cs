using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerLogFolder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CrawlerLogFolder(new string[] { "./", "wz4/", "../", "mj2/", "../", "../", "ik0/", "il7/" }));
            Console.WriteLine(CrawlerLogFolder(new string[] { "d1/", "d2/", "../", "d21/", "./" }));
            Console.WriteLine(CrawlerLogFolder(new string[] { "d1/", "d2/", "./", "d3/", "../", "d31/" }));
            Console.WriteLine(CrawlerLogFolder(new string[] { "d1/", "../", "../", "../" }));
        }
        public static int CrawlerLogFolder(string[] logs)
        {
            int counter = 0;

            for (int i = 0; i < logs.Length; i++)
            {
                if (logs[i] == "../")
                {
                    counter--;
                    if (counter < 0)
                        counter = 0;
                }
                else if (logs[i] == "./")
                    continue;
                else
                    counter++;
            }
            return counter > 0 ? counter : 0;
        }
    }
}
