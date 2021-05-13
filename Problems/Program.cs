using System.Collections.Generic;
using System;
namespace LeetCode
{
    public static class Program
    {
        static void Main(string[] args)
        {
            LeetCode9 prog = new LeetCode9();
            #region Matrix
            int[][] arra = new int[2][];
            arra[0] = new int[] { 1, 2, 3 };
            arra[1] = new int[] { 4, 5, 6 };
            //arra[2] = new int[] { 1, 1, 0 };
            #endregion

            #region List
            ListNode list = new ListNode(0);
            ListNode list1 = new ListNode(1);
            ListNode list2 = new ListNode(2);
            ListNode list3 = new ListNode(4);
            ListNode list4 = new ListNode(5);
            ListNode list5 = new ListNode(6);
            list.next = list1;
            list1.next = list2;
            list3.next = list4;
            list4.next = list5;

            #endregion

            #region Tree
            var root = new TreeNode(1);
            var root1 = new TreeNode(2);
            var root2 = new TreeNode(3);
            var root3 = new TreeNode(4);
            var root4 = new TreeNode(5);
            root2.left = root3;
            root2.right = root4;
            root.left = root1;
            root.right = root2;

            #endregion
            int num = Int32.MaxValue;
            System.Console.WriteLine(prog.IsPalindrome(num));
        }
    }
}