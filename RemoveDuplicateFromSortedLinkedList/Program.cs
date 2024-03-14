using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateFromSortedLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static ListNode RemoveDuplicateFromSortedLinkedList(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            ListNode res = null;
            while (fast != null)
            {
                while (fast != null && slow.val == fast.val)
                    fast = fast.next;
                res = new ListNode(slow.val, res);
                if (fast == null)
                    break;
                while (slow.val != fast.val)
                    slow = slow.next;
            }
            ListNode final = res;
            res = null;
            while (final != null)
            {
                res = new ListNode(final.val, res);
                final = final.next;
            }
            return res;
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
