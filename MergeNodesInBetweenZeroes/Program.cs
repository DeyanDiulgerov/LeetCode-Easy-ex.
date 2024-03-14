using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeNodesInBetweenZeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static ListNode MergeNodesInBetweenZeroes(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head.next;
            ListNode res = null;
            while (fast != null)
            {
                int sum = 0;
                while (fast != null && fast.val != 0)
                {
                    sum += fast.val;
                    fast = fast.next;
                }
                res = new ListNode(sum, res);
                slow = slow.next;
                while (slow != null && slow.val != 0)
                    slow = slow.next;

                fast = fast.next;
            }
            ListNode final = null;
            ListNode curr = res;
            while (curr != null)
            {
                final = new ListNode(curr.val, final);
                curr = curr.next;
            }
            return final;
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
