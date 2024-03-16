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
        //2nd NEW Two Pointers
        public ListNode MiddleNode2(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }
        //1st Two Pointers
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
