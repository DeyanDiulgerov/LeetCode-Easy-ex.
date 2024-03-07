using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static ListNode ReverseList(ListNode head)
        {
            ListNode result = null;
            while (head != null)
            {
                result = new ListNode(head.val, result);
                head = head.next;
            }
            return result;
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
