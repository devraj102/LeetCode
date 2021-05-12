using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MergeTwoListsProblem
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }
            ListNode list = new ListNode(0);
            var runnerHead = list;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    runnerHead.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    runnerHead.next = l2;
                    l2 = l2.next;
                }

                runnerHead = runnerHead.next;
            }
            if (l1 != null)
            {
                runnerHead.next = l1;
            }
            if (l2 != null)
            {
                runnerHead.next = l2;
            }
            return list.next;
        }
    }
}
