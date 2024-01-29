using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementStackUsingQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();
            stack.Push(1);
            stack.Push(2);
            stack.Top();
            stack.Pop();
            stack.Empty();

            MyStack stack2 = new MyStack();
            stack2.Push(1);
            stack2.Push(2);
            stack2.Push(3);
            stack2.Pop();
            stack2.Push(4);
            stack2.Pop();
            stack2.Pop();
            stack2.Pop();
        }
        public class MyStack
        {
            Queue<int> queue;
            Queue<int> reversed;
            public MyStack()
            {
                queue = new Queue<int>();
                reversed = new Queue<int>();
            }
            public void Push(int x)
            {
                queue.Enqueue(x);
                reversed = new Queue<int>();
                Console.WriteLine(String.Join(",", queue));
                Console.WriteLine(String.Join(",", reversed));
                for (int i = queue.Count() - 1; i >= 0; i--)
                {
                    reversed.Enqueue(queue.ElementAt(i));
                }

                Console.WriteLine(String.Join(",", queue));
                Console.WriteLine(String.Join(",", reversed));
            }
            public int Pop()
            {
                Console.WriteLine(String.Join(",", queue));
                Console.WriteLine(String.Join(",", reversed));
                int curr = reversed.Dequeue();
                queue = new Queue<int>();

                for (int i = reversed.Count() - 1; i >= 0; i--)
                {
                    queue.Enqueue(reversed.ElementAt(i));
                }
                Console.WriteLine(String.Join(",", queue));
                Console.WriteLine(String.Join(",", reversed));
                return curr;
            }
            public int Top()
            {
                Console.WriteLine(String.Join(",", queue));
                Console.WriteLine(String.Join(",", reversed));
                int curr = reversed.Peek();
                return curr;
            }
            public bool Empty()
            {
                Console.WriteLine(String.Join(",", queue));
                Console.WriteLine(String.Join(",", reversed));
                return reversed.Count() == 0;
            }
        }
    }
}
