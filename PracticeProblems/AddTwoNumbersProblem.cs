namespace LeetCode
{
    public class AddTwoNumbersProblem
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode list = new ListNode(0);
            ListNode runner = list;
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                int value = carry;
                if (l1 != null)
                {
                    value += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    value += l2.val;
                    l2 = l2.next;
                }
                runner.next = new ListNode(value % 10);
                carry = value / 10;
                runner = runner.next;
            }
            
            if (carry > 0)
            {
                runner.next = new ListNode(carry);
                runner = runner.next;
            }
            return list.next;
        }
    }
}
