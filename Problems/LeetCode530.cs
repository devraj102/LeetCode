using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode530
    {
        List<int> list;
        public int GetMinimumDifference(TreeNode root)
        {

            list = new List<int>();
            TraverseTree(root);
            int min = int.MaxValue;
            for (int i = 1; i < list.Count; i++)
            {
                min = Math.Min(list[i] - list[i - 1], min);
            }
            return min;
        }
        public void TraverseTree(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            TraverseTree(root.left);
            list.Add(root.val);
            TraverseTree(root.right);
        }
    }
}
