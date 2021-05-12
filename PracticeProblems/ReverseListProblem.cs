using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ReverseListProblem
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            ListNode list = new ListNode(head.val);
            while (head.next != null)
            {
                head = head.next;
                ListNode currentNode = new ListNode(head.val);
                currentNode.next = list;
                list = currentNode;
            }
            return list;
        }
    }
}
