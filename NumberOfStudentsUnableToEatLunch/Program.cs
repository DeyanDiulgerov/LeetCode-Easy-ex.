using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfStudentsUnableToEatLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfStudentsUnableToEatLunch(
                new int[] { 1, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1 },
                new int[] { 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0 }));

            Console.WriteLine(NumberOfStudentsUnableToEatLunch(
                new int[] { 1, 1, 1, 0, 0, 1 }, new int[] { 1, 0, 0, 0, 1, 1 }));
            Console.WriteLine(NumberOfStudentsUnableToEatLunch(new int[] { 1, 1, 0, 0 }, new int[] { 0, 1, 0, 1 }));
        }

        public static int NumberOfStudentsUnableToEatLunch(int[] students, int[] sandwiches)
        {
            Queue<int> queue = new Queue<int>(students);
            Stack<int> stack = new Stack<int>(sandwiches.Reverse());
            while (true)
            {
                if (queue.All(x => x != stack.Peek()))
                    break;
                if(queue.Peek() == stack.Peek())
                {
                    queue.Dequeue();
                    stack.Pop();
                }
                else
                    queue.Enqueue(queue.Dequeue());
            }
            return stack.Count;
        }
    }
}
