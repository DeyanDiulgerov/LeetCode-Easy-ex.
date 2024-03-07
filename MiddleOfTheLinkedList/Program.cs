using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleOfTheLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static ListNode MiddleNode(ListNode head)
        {
            int count = 0;
            ListNode current = head;

            while (current != null)
            {
                count++;
                current = current.next;
            }
            current = head;
            for (int i = 0; i < count / 2; i++)
                current = current.next;
            return current;
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
