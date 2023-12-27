using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfRecentCalls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RecentCounter counter = new RecentCounter();
            counter.Ping(1);
            counter.Ping(100);
            counter.Ping(3001);
            counter.Ping(3002);
        }
        public class RecentCounter
        {
            Queue<int> allRequestsQueue = new Queue<int>();
            public RecentCounter()
            {
                allRequestsQueue = new Queue<int>();
            }

            public int Ping(int t)
            {
                allRequestsQueue.Enqueue(t);
                while (allRequestsQueue.Peek() < t - 3000)
                {
                    allRequestsQueue.Dequeue();
                }
                return allRequestsQueue.Count();
            }
        }
    }
}
