using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode138
    {
        public Node CopyRandomList(Node head)
        {
            Dictionary<Node, Node> dict = new Dictionary<Node, Node>();

            Node dummy = new Node(Int32.MinValue),
                 cur = dummy,
                 original = head;

            while (original != null)
            {
                Node temp = new Node(original.val);

                dict.Add(original, temp);

                original = original.next;
                cur.next = temp;
                cur = cur.next;
            }

            original = head;

            while (original != null)
            {
                dict[original].random = original.random == null ? null : dict[original.random];

                original = original.next;
            }

            return dummy.next;
        }
    }
}
