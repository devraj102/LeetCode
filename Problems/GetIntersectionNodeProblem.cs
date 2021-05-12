using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class GetIntersectionNodeProblem
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var list1 = Count(headA);
            var list2 = Count(headB);
            int counter = 0;
            if (list1 > list2)
            {
                while (counter != Math.Abs(list1 - list2))
                {
                    headA = headA.next;
                    counter++;
                }
            }
            else
            {
                while (counter != Math.Abs(list1 - list2))
                {
                    headB = headB.next;
                    counter++;
                }
            }
            while (headA != null && headB != null)
            {
                if (headA == headB)
                {
                    return headA;
                }
                headA = headA.next;
                headB = headB.next;
            }
            return null;
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
