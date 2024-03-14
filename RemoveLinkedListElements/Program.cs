using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveLinkedListElements
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static ListNode RemoveLinkedListElements(ListNode head, int val)
        {
            ListNode temp = null;
            ListNode curr = head;
            while (curr != null)
            {
                if (curr.val != val)
                    temp = new ListNode(curr.val, temp);
                curr = curr.next;
            }
            curr = temp;
            ListNode res = null;
            while (curr != null)
            {
                res = new ListNode(curr.val, res);
                curr = curr.next;
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
