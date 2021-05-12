using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode148
    {
        public ListNode SortList(ListNode head)
        {
            List<int> list = new List<int>();
            while(head!=null)
            {
                list.Add(head.val);
                head = head.next;
            }
            list.Sort();
            ListNode node = new ListNode(-1);
            var runner = node;
            foreach (var item in list)
            {
                runner = new ListNode(item);
                runner.next = runner;
            }
            return node.next;
        }
    }
}
