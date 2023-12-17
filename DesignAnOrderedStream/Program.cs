using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAnOrderedStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderedStream os = new OrderedStream(5);
            os.Insert(3, "ccccc");
            os.Insert(1, "aaaaa");
            os.Insert(2, "bbbbb");
            os.Insert(5, "eeeee");
            os.Insert(4, "ddddd");
        }

        public class OrderedStream
        {
            List<string> stream = new List<string>();
            List<string> alreadyPrinted = new List<string>();
            public OrderedStream(int n)
            {
                for (int i = 0; i < n; i++)
                {
                    stream.Add("");
                }
            }

            public IList<string> Insert(int idKey, string value)
            {
                stream[idKey - 1] = value;
                var shouldPrintList = new List<string>();


                for (int i = 0; i < stream.Count(); i++)
                {
                    if (stream[i] != "")
                    {
                        if (!alreadyPrinted.Contains(stream[i]))
                        {
                            shouldPrintList.Add(stream[i]);
                            alreadyPrinted.Add(stream[i]);
                        }
                    }
                    else
                        break;
                }

                Console.WriteLine(String.Join(",", shouldPrintList));

                return shouldPrintList;
            }
        }
    }
}
