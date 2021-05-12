using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode141
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null)
            {
                return false;
            }
            if (head == head.next)
            {
                return true;
            }
            var tortoise = head;
            var rabbit = head.next;
            while (rabbit != null && rabbit.next != null)
            {
                if (tortoise == rabbit)
                {
                    return true;
                }
                rabbit = rabbit.next.next;
                tortoise = tortoise.next;
            }
            return false;
        }
    }
}
