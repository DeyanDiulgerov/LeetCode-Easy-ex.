using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementQueueUsingStacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue();
            queue.Push(1);
            queue.Push(2);
            queue.Push(3);
            queue.Peek();
            queue.Pop();
            queue.Empty();
        }
        public class MyQueue
        {
            Stack<int> stack;
            Stack<int> reversed;
            public MyQueue()
            {
                stack = new Stack<int>();
                reversed = new Stack<int>();
            }
            public void Push(int x)
            {
                stack.Push(x);
                reversed = new Stack<int>();
                for (int i = 0; i < stack.Count(); i++)
                {
                    reversed.Push(stack.ElementAt(i));
                }

                Console.WriteLine(String.Join(",", stack));
                Console.WriteLine(String.Join(",", reversed));
            }
            public int Pop()
            {
                Console.WriteLine(String.Join(",", stack));
                Console.WriteLine(String.Join(",", reversed));
                int curr = reversed.Pop();
                stack = new Stack<int>();

                for (int i = 0; i < reversed.Count(); i++)
                {
                    stack.Push(reversed.ElementAt(i));
                }
                Console.WriteLine(String.Join(",", stack));
                Console.WriteLine(String.Join(",", reversed));
                return curr;
            }
            public int Peek()
            {
                Console.WriteLine(String.Join(",", stack));
                Console.WriteLine(String.Join(",", reversed));
                int curr = reversed.Peek();
                return curr;
            }
            public bool Empty()
            {
                Console.WriteLine(String.Join(",", stack));
                Console.WriteLine(String.Join(",", reversed));
                return reversed.Count() == 0;
            }
        }
    }
}
