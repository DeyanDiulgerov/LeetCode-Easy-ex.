using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertBinaryNumberInALinkedListToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static int GetDecimalValue(ListNode head)
        {
            StringBuilder sb = new StringBuilder();
            while (head != null)
            {
                sb.Append(head.val);
                head = head.next;
            }
            return Convert.ToInt32(sb.ToString(), 2);
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
