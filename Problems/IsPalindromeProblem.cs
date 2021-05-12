using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class IsPalindromeProblem
    {
        public bool IsPalindrome(ListNode head)
        {
            var tail = ReverseList(head);
            while (head != null && tail != null)
            {
                if (head.val != tail.val)
                {
                    return false;
                }
                head = head.next;
                tail = tail.next;
            }
            return true;
        }
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
