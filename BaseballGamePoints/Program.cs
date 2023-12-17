using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGamePoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BaseballGamePoints(new string[] { "1", "C", "-62", "-45", "-68" }));
            Console.WriteLine(BaseballGamePoints(new string[] { "5", "2", "C", "D", "+" }));
            Console.WriteLine(BaseballGamePoints(new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" }));
            Console.WriteLine(BaseballGamePoints(new string[] { "1", "C" }));
        }

        public static int BaseballGamePoints(string[] operations)
        {
            var resultStack = new Stack<int>();
            int n = operations.Length;

            for (int i = 0; i < n; i++)
            {
                if (operations[i] == "+")
                {
                    var first = resultStack.Pop();
                    var second = resultStack.Peek();
                    resultStack.Push(first);
                    resultStack.Push(first + second);
                }
                else if (operations[i] == "D")
                {
                    var curr = resultStack.Peek();
                    resultStack.Push(curr * 2);
                }
                else if (operations[i] == "C")
                    resultStack.Pop();
                else
                    resultStack.Push(int.Parse(operations[i]));
            }
            return resultStack.Sum();
        }
    }
}
