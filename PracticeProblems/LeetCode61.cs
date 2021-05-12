using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode61
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
            {
                return null;
            }
            int count = Count(head);
            int p = count - k % count;
            ListNode back = new ListNode();
            ListNode runner = back;
            ListNode front = new ListNode();
            ListNode backword = front;
            while (p != 0)
            {
                runner.next = new ListNode(head.val);
                head = head.next;
                runner = runner.next;
                p--;
            }
            while (head != null)
            {
                backword.next = new ListNode(head.val);
                head = head.next;
                backword = backword.next;
            }
            back = back.next;
            while (back != null)
            {
                backword.next = new ListNode(back.val);
                back = back.next;
                backword = backword.next;
            }
            return front.next;
        }

        public int Count(ListNode head)
        {
            int count = 0;
            while (head != null)
            {
                head = head.next;
                count++;
            }
            return count;
        }
    }
}
